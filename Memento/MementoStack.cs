
namespace Lab5
{
    public class MementoStack
    {
        private readonly Stack<string> save = new Stack<string>();
        private readonly Stack<string> autosave = new Stack<string>();

        public void Push(string state, bool auto)
        {
            if (auto)
            {
                autosave.Push(state);
            }
            else
            {
                save.Push(state);
            }
        }

        public string? Pop(bool auto)
        {
            if (auto)
            {
                return autosave.Count > 0 ? autosave.Pop() : null;
            }
            else
            {
                return save.Count > 0 ? save.Pop() : null;
            }
        }
    }
}
