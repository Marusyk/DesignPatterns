using System;
using System.IO;

namespace CompilationSystem
{
    // Фасад.
    public class Compiler
    {
        Scanner scanner;
        Parser parser;
        ProgramNodeBuilder builder;
        CodeGenerator generator;

        ByteCodeStream stream;

        public Compiler()
        {
            this.stream = new ByteCodeStream();
            this.scanner = new Scanner();
            this.parser = new Parser();
            this.generator = new CISCCodeGenerator();
            this.builder = new ProgramNodeBuilder(this.generator);
        }

        /// <summary>
        /// Компиляция исходного кода на языке Assembler в машинный код.
        /// </summary>
        /// <param name="sourceCode">Исходный код программы на языке Assembler</param>
        /// <param name="exeFileLocation">Путь и имя исполняемого файла, который будет сгенерирован в результате компиляции</param>
        /// <param name="notification">Механизм передачи уведомлений от компилятора пользователю</param>
        public void Compile(string sourceCode, string exeFileLocation, Action<string> notification)
        {
            try
            {
                parser.Parse(scanner, builder, sourceCode);

                ProgramNode product = builder.GetProgramNode();

                this.stream.SaveStreamToFile(product.ProgramByteCode, exeFileLocation);

                notification("Компиляция завершилась успешно.");
            }
            catch (Exception ex)
            {
                string errorMessage = string.Format("Компиляция не удалась.\r\nОШИБКА: ");
                errorMessage += ex.GetType().Name + ":\n" + ex.Message;
                notification(errorMessage);
            }
        }
    }
}
