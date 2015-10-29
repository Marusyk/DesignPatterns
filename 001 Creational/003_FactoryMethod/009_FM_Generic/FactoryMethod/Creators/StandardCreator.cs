using System;
using System.Collections.Generic;

namespace FactoryMethod
{
    class StandardCreator : ICreator
    {       
        public T CreateProduct<T>()
        {          
            return Activator.CreateInstance<T>();
        }
    }
}
