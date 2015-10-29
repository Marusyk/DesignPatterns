using System;

// Прототипно-ориентированный подход в программировании.
// ПОП является подмножеством ООП.

namespace ObjectClass
{
    class Prototype
    {
        public string Class { get; set; }
        public string State { get; set; }

        public Prototype Clone()
        {
            return this.MemberwiseClone() as Prototype;
        }
    }

    class Program
    {
        static void Main()
        {
            // Формирование Объекта-Класса prototype, который будет
            // являться прототипом для всех производных от него видов. 
            Prototype prototype = new Prototype();
            prototype.Class = "Биологическая система";
            prototype.State = "";

            // Формирование Объекта-Класса Human.
            // Human - является клоном прототипа prototype.
            var Human = prototype.Clone() as Prototype;
            Human.Class = "Человек";
            Human.State += "Общие признаки человека";

            // Формирование Объекта-Класса Man.
            // Human - стал прототипом для клона Man. 
            // Man - является клоном прототипа Human.
            var Man = Human.Clone();
            Man.Class = "Мужчина";
            Man.State += "Мужские признаки";

            // Формирование Объекта-Класса Woman.
            // Human - стал прототипом для клона Woman. 
            // Woman - является клоном прототипа Human.
            var Woman = Human.Clone();
            Woman.Class = "Женщина";
            Woman.State += "Женские признаки";

            // НО! Если верить библии, что Ева является произведением из ребра Адама то:
            // требуется создать экземпляр Адама и клонировать его для произведения экземпляра Евы,
            // или нового вида-объектов женщин? Запутанная логика формирования вида через экземпляр...
            var adam = Human.Clone();
            adam.State = "Адам";

            var eva = adam.Clone();
            eva.State = "Ева";

      
            // ...
        }
    }
}
