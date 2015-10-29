using System;
using System.Collections.Generic;
using System.Linq;

namespace CompilationSystem
{
    class CISCCodeGenerator : CodeGenerator
    {
        // Переменные.
        List<VariableNode> _variables = new List<VariableNode>();

        public override List<VariableNode> Variables
        {
            get { return _variables; }
            set { _variables = value; }
        }

        #region Генераторы кодов машинных команд.

        public override void Initialize()
        {
            Array.Copy(StaticData, 0, Data, 0, StaticData.Length);
            dataPointer = StaticData.Length;
        }

        public override ByteCode GetNopCode()
        {
            return new ByteCode(0x90);
        }

        public override ByteCode GetCallCode(string[] parameters)
        {
            // Код операции команды CALL (0xE8) и четыре байта
            // для подстановки адреса перехода (0x00, 0x00, 0x00, 0x00).
            return new ByteCode(0xE8, 0x00, 0x00, 0x00, 0x00);
        }

        public override ByteCode GetXorCode(string[] parameters)
        {
            if (parameters[0].ToUpper() == Constants.eax)
                return new ByteCode(0x33, 0xC0);

            throw new NotSupportedException("Такой вариант команды XOR не поддерживается.");
        }

        public override ByteCode GetSubCode(string[] parameters)
        {
            if (parameters[0].ToUpper() == Constants.eax)
            {
                // Например: SUB EAX, var1 или SUB EAX, 22 (22 - непосредственное значение)
                VariableNode var1 = _variables.Where(x => x.Name == parameters[1]).FirstOrDefault();
                int parsedValue;

                if (var1 != null)
                    return new ByteCode((new byte[] { 0x2B, 0x05 }).Concat(var1.Address).ToArray());
                else if (int.TryParse(parameters[1], out parsedValue))
                    return new ByteCode((new byte[] { 0x2D }).Concat(BitConverter.GetBytes(parsedValue)).ToArray());
            }
            else if (parameters[1].ToUpper() == Constants.eax)
            {
                // Например: SUB var1, EAX 
                VariableNode var1 = _variables.Where(x => x.Name == parameters[0]).FirstOrDefault();

                if (var1 != null)
                    return new ByteCode((new byte[] { 0x29, 0x05 }).Concat(var1.Address).ToArray());
            }

            throw new NotSupportedException("Такой вариант команды SUB не поддерживается.");
        }

        public override ByteCode GetAddCode(string[] parameters)
        {
            if (parameters[0].ToUpper() == Constants.eax)
            {
                // Например: ADD EAX, var1 или ADD EAX, 22 (22 - непосредственное значение)
                VariableNode var1 = _variables.Where(x => x.Name == parameters[1]).FirstOrDefault();
                int parsedValue;

                if (var1 != null)
                    return new ByteCode((new byte[] { 0x03, 0x05 }).Concat(var1.Address).ToArray());
                else if (int.TryParse(parameters[1], out parsedValue))
                    return new ByteCode((new byte[] { 0x05 }).Concat(BitConverter.GetBytes(parsedValue)).ToArray());
            }
            else if (parameters[1].ToUpper() == Constants.eax)
            {
                // Например: ADD var1, EAX 
                VariableNode var1 = _variables.Where(x => x.Name == parameters[0]).FirstOrDefault();

                if (var1 != null)
                    return new ByteCode((new byte[] { 0x01, 0x05 }).Concat(var1.Address).ToArray());
            }

            throw new NotSupportedException("Такой вариант команды ADD не поддерживается.");
        }

        public override ByteCode GetMovCode(string[] parameters)
        {
            if (parameters[0].ToUpper() == Constants.eax)
            {
                // Например: MOV EAX, var1 или MOV EAX, 22 (22 - непосредственное значение)
                Func<VariableNode, bool> expr = x => x.Name == parameters[1];
                VariableNode var1 = _variables.Where(expr).FirstOrDefault();
                int parsedValue;

                if (var1 != null)
                    return new ByteCode((new byte[] { 0xA1 }).Concat(var1.Address).ToArray());
                else if (int.TryParse(parameters[1], out parsedValue))
                    return new ByteCode((new byte[] { 0xB8 }).Concat(BitConverter.GetBytes(parsedValue)).ToArray());
            }
            else if (parameters[1].ToUpper() == Constants.eax)
            {
                // Например: MOV var1, EAX
                VariableNode var1 = _variables.Where(x => x.Name == parameters[0]).FirstOrDefault();

                if (var1 != null)
                    return new ByteCode((new byte[] { 0xA3 }).Concat(var1.Address).ToArray());
            }

            throw new NotSupportedException("Такой вариант команды MOV не поддерживается.");
        }

        public override void SetDataVariable(VariableNode node)
        {
            List<byte> bytes = BitConverter.GetBytes(node.Value).ToList();
            
            Array.Copy(bytes.ToArray(), 0, Data, dataPointer, 4);

            node.Address = GetAddressByOffcet(dataPointer);
            dataPointer += 4;

            _variables.Add(node);
        }

        private byte[] GetAddressByOffcet(int offset)
        {
            int address = Constants.dataSegmentStartPoint + offset;

            List<byte> addressParts = BitConverter.GetBytes(address).ToList();

            return addressParts.ToArray();
        }

        public override void FixFunctionAddresses()
        {
            StatementNode exitProcess = functions.Where(x => x.Name == "ExitProcess").FirstOrDefault();
            StatementNode hexMessage = functions.Where(x => x.Name == "HexMessage").FirstOrDefault();

            hexMessage.Address = Constants.programSegmentStartPoint + programPointer;
            exitProcess.Address = Constants.programSegmentStartPoint + programPointer + 0x35;

            foreach (StatementNode function in functions)
            {
                foreach (int offcet in function.Offsets)
                {
                    byte[] bytes = BitConverter.GetBytes(function.Address - (Constants.programSegmentStartPoint + offcet + 4));
                    Array.Copy(bytes, 0, Body, offcet, 4);
                }
            }
        }
        public override ByteCode GenerateByteCode()
        {
            FixFunctionAddresses();
            return new ByteCode(Header.Concat(Body).Concat(ImportTable).Concat(Data).ToArray());
        }
        #endregion    
    }
}
