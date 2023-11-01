
namespace Lab5
{
    public class Circle : IFigure
    {
        private int X;
        private int Y;
        private string? Color;
        private readonly ICommand _command;
        private readonly IEditor _editor;

        public Circle(ICommand command, IEditor editor)
        {
            Color = "None";
            _command = command;
            _editor = editor;
        }

        public void Draw(int x, int y, string color)
        {
            _command.Execute();
            X = x;
            Y = y;
            Color = color;
            _editor.AddFigure(this);
        }

        public void Move(int deltaX, int deltaY)
        {
            _command.Execute();
            X += deltaX;
            Y += deltaY;

        }

        public void ChangeColor(string color)
        {
            _command.Execute();
            Color = color;

        }

        public string GetState()
        {
            return $"{X},{Y},{Color}";
        }

        public void SetState(string state)
        {
            var values = state.Split(',');
            if (values.Length == 3)
            {
                X = int.Parse(values[0]);
                Y = int.Parse(values[1]);
                Color = values[2];
            }
        }

        public override string ToString()
        {
            return $"Circle in ({X};{Y}), color {Color}";
        }
    }
}
