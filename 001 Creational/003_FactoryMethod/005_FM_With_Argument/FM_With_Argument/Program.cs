
namespace FM_With_Argument
{
    class Program
    {
        static void Main()
        {
            Creator creator = new MyCreator();
            Product product = creator.Create(ProductType.THEIRS);
        }
    }
}
