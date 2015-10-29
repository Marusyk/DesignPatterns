using System;


namespace ServiceLocator_1
{
    interface IServiceLocator
    {
        T GetService<T>();
    }
}
