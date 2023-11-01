
namespace Lab5
{
    public class UndoCommand : ICommand
    {
        private readonly Editor editor;
        private readonly MementoStack stack;
        private readonly bool auto = true;

        public UndoCommand(Editor editor, MementoStack stack)
        {
            this.editor = editor;
            this.stack = stack;
        }

        public void Execute()
        {
            var state = stack.Pop(auto);
            if (state != null)
            {
                editor.SetState(state);
            }
        }
    }
}
