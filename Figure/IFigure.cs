
namespace Lab5
{
    public interface IFigure
    {
        void Draw(int x, int y, string color);
        void Move(int xOffset, int yOffset);
        void ChangeColor(string color);
        string GetState();
        void SetState(string state);
    }
}
