using System;

namespace Command
{
    // "Receiver" (����������) - �������������� ���������� (��)
    class ArithmeticUnit
    {
        public int Register { get; private set; }

        public void Run(char operationCode, int operand)
        {
            switch (operationCode)
            {
                case '+':
                    Register += operand;
                    break;
                case '-':
                    Register -= operand;
                    break;
                case '*':
                    Register *= operand;
                    break;
                case '/':
                    Register /= operand;
                    break;
            }
        }
    }
}
