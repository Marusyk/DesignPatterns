namespace Adapter
{
    /// <summary>
    /// Класс DrawingEditor - клиент, вступающий во взаимоотношение с обьектами,
    /// удовлетворяющими интерфейсу Shape.
    /// </summary>
    class DrawingEditor
    {
        Shape shape;
        public Manipulator Manipulator { get; set; }

        public DrawingEditor(Shape shape)
        {
            this.shape = shape;
        }

        public void Draw()
        {
            shape.BoundingBox();
            Manipulator = shape.CreateManipulator();
        }
    }
}
