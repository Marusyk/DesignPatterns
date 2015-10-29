using System.IO;

namespace CompilationSystem
{
    class ByteCodeStream
    {
        public void SaveStreamToFile(ByteCode programByteCode, string exeFileLocation)
        {
            using (FileStream fileStream = File.Create(exeFileLocation, programByteCode.Code.Length))
            {
                fileStream.Write(programByteCode.Code, 0, programByteCode.Code.Length);
            }
        }
    }
}
