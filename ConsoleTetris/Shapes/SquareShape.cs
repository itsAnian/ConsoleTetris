namespace ConsoleTetris.Shapes;

public class SquareShape : IShape
{
    public Block Block1 { get; set; }
    public Block Block2 { get; set; }
    public Block Block3 { get; set; }
    public Block Block4 { get; set; }
    public int RotationState { get; set; }
    private TetrisObjectService _tetrisObjectService;

    public SquareShape(int xCoordinate, int yCoordinate)
    {
        Block1 = new Block(ColorEnum.Yellow, xCoordinate + 0, yCoordinate + 0);
        Block2 = new Block(ColorEnum.Yellow, xCoordinate + 1, yCoordinate + 0);
        Block3 = new Block(ColorEnum.Yellow, xCoordinate + 0, yCoordinate + 1);
        Block4 = new Block(ColorEnum.Yellow, xCoordinate + 1, yCoordinate + 1);
        RotationState = 0;
        _tetrisObjectService = new TetrisObjectService();
    }

    public void Turn()
    {
        Console.WriteLine("Jokes on you :)");
    }
}
