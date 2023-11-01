
namespace Lab5
{
    public class SaveCommand : ICommand
    {
        private readonly Editor editor;
        private readonly MementoStack stack;
        private readonly bool auto = false;

        public SaveCommand(Editor editor, MementoStack stack)
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
