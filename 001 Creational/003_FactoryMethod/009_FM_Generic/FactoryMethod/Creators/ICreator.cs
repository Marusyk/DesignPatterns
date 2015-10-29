using System;

namespace FactoryMethod
{
    interface ICreator
    {
        T CreateProduct<T>();
    }
}
