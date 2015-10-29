using System;
using System.Collections;

namespace List
{
    class List : IList // IList унаследован от ICollection и IEnumerable.
    {
        ArrayList elements = new ArrayList();

        #region IList Members

        /// <summary>
        /// Добавляет элемент в список IList.
        /// </summary>
        /// <param name="value">Элемент который требуется поместить в коллекцию.</param>
        /// <returns>Индекс элемента который помещен в коллекцию.</returns>
        public int Add(object value)
        {
            return elements.Add(value);
        }

        // Удаляет все элементы из коллекции IList.
        public void Clear()
        {
            elements.Clear();
        }

        // Определяет, содержится ли указанное значение в списке IList.
        public bool Contains(object value)
        {
            return elements.Contains(value);
        }

        // Определяет индекс заданного элемента в списке IList.
        public int IndexOf(object value)
        {
            return elements.IndexOf(value);
        }

        // Вставляет элемент в коллекцию IList с заданным индексом.
        public void Insert(int index, object value)
        {
            elements.Insert(index, value);
        }

        // Получает значение, показывающее, имеет ли список IList фиксированный размер.
        public bool IsFixedSize
        {
            get { return elements.IsFixedSize; }
        }

        // Получает значение, указывающее, доступна ли коллекция IList только для чтения.
        public bool IsReadOnly
        {
            get { return elements.IsReadOnly; }
        }

        // Удаляет первое вхождение указанного объекта из списка IList.
        public void Remove(object value)
        {
            elements.Remove(value);
        }

        // Удаляет элемент IList, расположенный по указанному индексу.
        public void RemoveAt(int index)
        {
            elements.RemoveAt(index);
        }

        public object this[int index]
        {
            get { return elements[index]; }
            set { elements[index] = value; }
        }

        #endregion

        #region ICollection Members
        public void CopyTo(Array array, int index)
        {
            elements.CopyTo(array, index);
        }
        public int Count
        {
            get { return elements.Count; }
        }
        public bool IsSynchronized
        {
            get { return elements.IsSynchronized; }
        }
        public object SyncRoot
        {
            get { return elements.SyncRoot; }
        }

        #endregion

        #region Реализация IEnumerable

        public IEnumerator GetEnumerator()
        {
            return elements.GetEnumerator();
        }

        #endregion
    }
}
