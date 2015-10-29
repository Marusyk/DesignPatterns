
namespace FM_With_Argument
{
    class Creator
    {
        public virtual Product Create(ProductType productType)
        {
            if (productType == ProductType.MINE)
                return new MyProduct();
            else if (productType == ProductType.YOURS)
                return new YourProduct();
            else
                return null;
        }
    }
}
