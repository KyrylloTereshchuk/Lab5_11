
namespace Lab5
{
    public class Editor : IEditor
    {
        private List<IFigure> figures = new List<IFigure>();

        public void AddFigure(IFigure figure)
        {
            figures.Add(figure);
        }

        public string GetState()
        {
            var state = new List<string>();
            foreach (var figure in figures)
            {
                state.Add(figure.GetState());
            }
            return string.Join(";", state);
        }

        public void SetState(string state)
        {
            var stateValues = state.Split(';');
            if (stateValues.Length == figures.Count)
            {
                for (int i = 0; i < figures.Count; i++)
                {
                    figures[i].SetState(stateValues[i]);
                }
            }
        }

        public void PrintFigures()
        {
            Console.WriteLine("Current Figures:");
            foreach (var figure in figures)
            {
                Console.WriteLine(figure.ToString());
                Console.WriteLine();
            }
        }
    }
}