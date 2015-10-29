using System;
using System.Collections.Generic;
using System.Linq;

namespace ObserverChangeManager
{
    class DAGChangeManager : ChangeManager, IEqualityComparer<Tuple<Subject, Observer>>
    {
        static DAGChangeManager singleton = new DAGChangeManager();

        public static DAGChangeManager Singleton
        {
            get { return singleton; }
        }

        private DAGChangeManager()
        {
        }

        // Регистрация подписчика в списке издателя.
        public override void Register(Subject subject, Observer observer)
        {
            if (!mapping.ContainsKey(subject))
                mapping.Add(subject, new List<Observer>());

            mapping[subject].Add(observer);
        }

        // Удаление подписчика из списка издателя.
        public override void Unregister(Subject subject, Observer observer)
        {
            if (!mapping.ContainsKey(subject))
                return;

            mapping[subject].Remove(observer);
        }

        // Уведомление подписчика только 1 раз вне зависимости от того, на скольких издателей он был подписан.
        public override void Notify()
        {
            // Выбор кортежей, в которых конкретный экземпляр типа Observer встречается только 1 раз.
            var tuples = mapping.SelectMany(kv => kv.Value.Select(observer => new Tuple<Subject, Observer>(kv.Key, observer))).Distinct(this);

            // Уведомление подписчиков.
            foreach (var tuple in tuples)
                tuple.Item2.Update(tuple.Item1);
        }
        
        // Реализация интерфейса IEqualityComparer<Tuple<Subject, Observer>>

        bool IEqualityComparer<Tuple<Subject, Observer>>.Equals(Tuple<Subject, Observer> x, Tuple<Subject, Observer> y)
        {
            return x.Item2.Equals(y.Item2);
        }

        int IEqualityComparer<Tuple<Subject, Observer>>.GetHashCode(Tuple<Subject, Observer> tuple)
        {
            return tuple.Item2.GetHashCode();
        }
    }
}
