namespace ConsoleTetris.Shapes;

public class JShape : ITetrisObject
{
    public Block Block1 { get; set; }
    public Block Block2 { get; set; }
    public Block Block3 { get; set; }
    public Block Block4 { get; set; }

    public JShape(int xCoordinate, int yCoordinate)
    {
        Block1 = new Block(ColorEnum.Blue, xCoordinate + 0, yCoordinate + 0);
        Block2 = new Block(ColorEnum.Blue, xCoordinate + 1, yCoordinate + 0);
        Block3 = new Block(ColorEnum.Blue, xCoordinate + 2, yCoordinate + 0);
        Block4 = new Block(ColorEnum.Blue, xCoordinate + 2, yCoordinate + 1);
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