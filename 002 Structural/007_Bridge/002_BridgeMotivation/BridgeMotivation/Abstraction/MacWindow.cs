
namespace WidgetFactoryApplication
{
    // RefinedAbstraction
    class MacWindow : Window
    {
        public MacWindow()
        {
            this.implementor = new MacWindowImp();
            this.form = this.implementor.DevDrawForm();
            this.button = this.implementor.DevDrawButton();
        }

        // Operation
        public override void Draw()
        {
            form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            base.Draw();
        }
    }
}
