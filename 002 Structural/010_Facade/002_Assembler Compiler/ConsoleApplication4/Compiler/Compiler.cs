using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Compiler
{
    public class Compiler
    {
        Scanner _scaner = Scanner.Instance;
        Parser _parser = Parser.Instance;
        ProgramNodeBuilder _programNodeBuilder = ProgramNodeBuilder.Instance;

        static Compiler _instance;
        public static Compiler Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Compiler();
                }

                return _instance;
            }
        }

        protected Compiler()
        {
        }



        public Stream Compile(string program, out string errorMessage)
        {
            string[] nods;
            string error;

            try
            {
                error = _scaner.Scan(program, out nods);
                if (!string.IsNullOrEmpty(error))
                {
                    errorMessage = error;
                    return null;
                }

                error = _parser.Parse(nods);
                if (!string.IsNullOrEmpty(error))
                {
                    errorMessage = error;
                    return null;
                }

                errorMessage = null;
                return _programNodeBuilder.Run(nods);
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
                return null;
            }
        }
    }
}
