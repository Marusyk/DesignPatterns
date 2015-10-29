using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Compiler
{
    internal enum Command
    {
        MOV,
        ADD,
        SUB,
        XOR,
        CALL,
        NOP
    }

    internal static class Constants
    {
        private static char[] _programDelimiter = new char[] { ';' };
        public static char[] ProgramDelimiter { get { return _programDelimiter; } }

        private static char[] _lexemesDelimiter = new char[] { ' ' };
        public static char[] LexemesDelimiter { get { return _lexemesDelimiter; } }

        private static char[] _parameterDelimiter = new char[] { ',' };
        public static char[] ParameterDelimiter { get { return _parameterDelimiter; } }

        private static int _dataSegmentStartPoint = 0x00403000;
        public static int DataSegmentStartpoint { get { return _dataSegmentStartPoint; } }

        private static int _programSegmentStartPoint = 0x00401000;
        public static int ProgramSegmentStartpoint { get { return _programSegmentStartPoint; } }

        private static string _eax = "EAX";
        public static string EAX { get { return _eax; } }
    }
}
