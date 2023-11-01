
namespace Lab5
{
    public class AutosaveCommand : ICommand
    {
        private readonly Editor editor;
        private readonly MementoStack stack;
        private readonly bool auto = true;

        public AutosaveCommand(Editor editor, MementoStack stack)
        {
            this.editor = editor;
            this.stack = stack;
        }

        public void Execute()
        {
            var state = editor.GetState();
            stack.Push(state, auto);
        }
    }
}
