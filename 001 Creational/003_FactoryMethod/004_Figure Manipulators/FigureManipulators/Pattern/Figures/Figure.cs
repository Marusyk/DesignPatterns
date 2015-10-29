
namespace FigureManipulators
{
    // Абстрактный класс Figure предоставляет фабричный метод CreateManipulator(), 
    // позволяющий создать манипулятор соответствующий определенной фигуре. 
    public abstract class Figure
    {
        public Manipulator manipulator { get; set; }
        public abstract Manipulator CreateManipulator();
    }
}
