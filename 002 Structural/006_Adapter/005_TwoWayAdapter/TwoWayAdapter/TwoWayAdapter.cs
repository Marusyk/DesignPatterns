
namespace TwoWayAdapter
{
    class TwoWayAdapter : ITargetOld, ITargetNew
    {
        dynamic adaptee = null;

        void ITargetOld.MethodOld()
        {
            if (this.adaptee == null)
                this.adaptee = new AdapteeNew();

            this.adaptee.MethodNew();
        }

        void ITargetNew.MethodNew()
        {
            if (this.adaptee == null)
                this.adaptee = new AdapteeOld();

            this.adaptee.MethodOld();
        }
    }
}
