
namespace Lab5
{
    public  class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Editor editor = new ();
            MementoStack mementoStack = new ();

            ICommand save = new SaveCommand(editor, mementoStack);
            ICommand restore = new RestoreCommand(editor, mementoStack);
            ICommand autosave = new AutosaveCommand(editor, mementoStack);
            ICommand undo = new UndoCommand(editor, mementoStack);

            IFigure triangle = new Triangle(autosave, editor);

            triangle.Draw(10, 20, "Red");
            Console.WriteLine("Фігури після їх намалювання");
            editor.PrintFigures();

            save.Execute();

            triangle.ChangeColor("Purple");
            triangle.ChangeColor("Black");
            triangle.ChangeColor("Green");
            triangle.ChangeColor("Yellow");
            triangle.ChangeColor("Blue");
            Console.WriteLine("Фігури після переміщення та зміни кольору");
            editor.PrintFigures();

            undo.Execute();
            Console.WriteLine("Фігури після відновлення стану");
            editor.PrintFigures();

            undo.Execute();
            Console.WriteLine("Фігури після відновлення стану");
            editor.PrintFigures();

            restore.Execute();
            Console.WriteLine("Фігури після відновлення стану");
            editor.PrintFigures();

            Console.ReadLine();
        }
    }



        
    
}
