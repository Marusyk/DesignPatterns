using System;

namespace AbstractFactory
{
    interface IAbstractFactory
    {
        dynamic Make(Product product);
    }
}
