namespace State
{
    internal abstract class State
    {
        internal virtual void HandleMark(Father father, Mark mark)
        {
            ChangeState(father, mark);
        }

        protected abstract void ChangeState(Father father, Mark mark);
    }
}
