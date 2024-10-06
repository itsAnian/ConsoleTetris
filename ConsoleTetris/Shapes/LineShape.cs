namespace ConsoleTetris.Shapes;

public class LineShape : ITetrisObject
{
    public Block Block1 { get; set; }
    public Block Block2 { get; set; }
    public Block Block3 { get; set; }
    public Block Block4 { get; set; }

    public LineShape(int xCoordinate, int yCoordinate)
    {
        Block1 = new Block(ColorEnum.Cyan, xCoordinate + 0, yCoordinate);
        Block2 = new Block(ColorEnum.Cyan, xCoordinate + 1, yCoordinate);
        Block3 = new Block(ColorEnum.Cyan, xCoordinate + 2, yCoordinate);
        Block4 = new Block(ColorEnum.Cyan, xCoordinate + 3, yCoordinate);
    }
    public void GetPosition()
    {
        throw new NotImplementedException();
    }

    public void Turn()
    {
        throw new NotImplementedException();
    }
    
    public void MoveLeft()
    {
        if (Block1.XCooridnate != 0 && Block2.XCooridnate != 0 && Block3.XCooridnate != 0 && Block4.XCooridnate != 0)
        {
            Block1.XCooridnate--;
            Block2.XCooridnate--;
            Block3.XCooridnate--;
            Block4.XCooridnate--;
        }
    }

    public void MoveRight()
    {
        if (Block1.XCooridnate != Globals.WIDTH - 1 && Block2.XCooridnate != Globals.WIDTH - 1 && Block3.XCooridnate != Globals.WIDTH - 1 && Block4.XCooridnate != Globals.WIDTH - 1)
        {
            Block1.XCooridnate++;
            Block2.XCooridnate++;
            Block3.XCooridnate++;
            Block4.XCooridnate++;
        }
    }

    public void MoveDown()
    {
        throw new NotImplementedException();
    }
}