using System;
using System.Collections;

namespace Collection
{
    class Collection : ICollection
    {
        readonly object syncRoot = new object();

        readonly object[] elements = { 1, 2, 3, 4 };

        // Копирует элементы ICollection в Array, начиная с конкретного индекса Array.
        public void CopyTo(Array array, int userArrayIndex)
        {
            elements.CopyTo(array, userArrayIndex);
        }

        // Возвращает число элементов, содержащихся в коллекции ICollection.
        public int Count
        {
            get { return elements.Length; }
        }

        // Возвращает значение, позволяющее определить, является ли доступ 
        // к коллекции ICollection синхронизированным (потокобезопасным).
        public bool IsSynchronized
        {
            get { return true; }
        }

        // Возвращает объект, который можно использовать для 
        // синхронизации доступа к ICollection.
        public object SyncRoot
        {
            get { return syncRoot; }
        }

        // Возвращает перечислитель, который выполняет итерацию 
        // по элементам коллекции. (Реализация IEnumerable.)
        public IEnumerator GetEnumerator()
        {
            return elements.GetEnumerator();
        }
    }
}
