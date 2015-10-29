
namespace RegistSingleton
{
    class SingletonSmall : Singleton
    {
        protected SingletonSmall() { }

        public static new SingletonSmall Instance()
        {
            instance = Lookup(SingletonName.Small);

            if (instance == null)
            {
                Register(SingletonName.Small, new SingletonSmall());
                instance = Lookup(SingletonName.Small);
            }

            return instance as SingletonSmall;
        }
    }
}
