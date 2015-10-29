
namespace CompilationSystem
{
    class ByteCode
    {
        byte[] code = null;

        public byte[] Code
        {
            get { return code; }
        }

        public ByteCode(params byte[] code)
        {
            this.code = code;
        }
    }
}
