
namespace Lab5
{
    public class RestoreCommand : ICommand
    {
        private readonly Editor editor;
        private readonly MementoStack stack;
        private readonly bool auto = false;

        public RestoreCommand(Editor editor, MementoStack stack)
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
