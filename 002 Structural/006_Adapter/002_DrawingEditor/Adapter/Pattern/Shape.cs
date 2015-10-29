namespace Adapter
{
    /// <summary>
    /// Абстрактный класс Shape - определяет зависящий от предметной области интерфейс,
    /// которым пользуется клиент.
    /// </summary>
    public abstract class Shape
    {
        public abstract void BoundingBox();
        public abstract Manipulator CreateManipulator();
    }
}
