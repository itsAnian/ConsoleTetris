namespace ConsoleTetris.Shapes;

public class SquareShape : ITetrisObject
{
    public Block Block1 { get; set; }
    public Block Block2 { get; set; }
    public Block Block3 { get; set; }
    public Block Block4 { get; set; }

    public SquareShape(int xCoordinate, int yCoordinate)
    {
        Block1 = new Block(ColorEnum.Yellow, xCoordinate + 0, yCoordinate + 0);
        Block2 = new Block(ColorEnum.Yellow, xCoordinate + 1, yCoordinate + 0);
        Block3 = new Block(ColorEnum.Yellow, xCoordinate + 0, yCoordinate + 1);
        Block4 = new Block(ColorEnum.Yellow, xCoordinate + 1, yCoordinate + 1);
    }

    public void SetStationary()
    {
        Block1.State = StateEnum.Stationary;
        Block2.State = StateEnum.Stationary;
        Block3.State = StateEnum.Stationary;
        Block4.State = StateEnum.Stationary;
    }
    public void GetPosition()
    {
        throw new NotImplementedException();
    }

    public void Turn()
    {
        throw new NotImplementedException();
    }
}
