
namespace FM_With_Argument
{
    abstract class Product
    {
        public Product()
        {
            System.Console.WriteLine(this.GetType().Name);
        }
    }
}
