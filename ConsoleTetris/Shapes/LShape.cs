namespace ConsoleTetris.Shapes;

public class LShape : IShape
{
    
    public Block Block1 { get; set; }
    public Block Block2 { get; set; }
    public Block Block3 { get; set; }
    public Block Block4 { get; set; }
    public int RotationState { get; set; }
    private TetrisObjectService _tetrisObjectService;

    public LShape(int xCoordinate, int yCoordinate)
    {
        Block1 = new Block(ColorEnum.DarkYellow, xCoordinate + 0, yCoordinate + 1);
        Block2 = new Block(ColorEnum.DarkYellow, xCoordinate + 1, yCoordinate + 1);
        Block3 = new Block(ColorEnum.DarkYellow, xCoordinate + 2, yCoordinate + 1);
        Block4 = new Block(ColorEnum.DarkYellow, xCoordinate + 2, yCoordinate + 0);
        RotationState = 0;
        _tetrisObjectService = new TetrisObjectService();
    }

    public void Turn()
    {
        if (RotationState < 270)
        {
            RotationState += 90;
        }
        else
        {
            RotationState = 0;
        }

        switch (RotationState)
        {
            case 0:
                Block1.XCooridnate = Block1.XCooridnate - 1;
                Block1.YCooridnate = Block1.YCooridnate - 1;
                //Block2.XCooridnate = Block2.XCooridnate + 0;
                //Block2.YCooridnate = Block2.YCooridnate + 0;
                Block3.XCooridnate = Block3.XCooridnate + 1;
                Block3.YCooridnate = Block3.YCooridnate + 1;
                Block4.XCooridnate = Block4.XCooridnate + 2;
                //Block4.YCooridnate = Block4.YCooridnate + 0;

                _tetrisObjectService.CheckIfInBorder(Block1, Block2, Block3, Block4);

                break;
            case 90:
                Block1.XCooridnate = Block1.XCooridnate + 1;
                Block1.YCooridnate = Block1.YCooridnate - 1;
                //Block2.XCooridnate = Block2.XCooridnate + 0;
                //Block2.YCooridnate = Block2.YCooridnate + 0;
                Block3.XCooridnate = Block3.XCooridnate - 1;
                Block3.YCooridnate = Block3.YCooridnate + 1;
                //Block4.XCooridnate = Block4.XCooridnate + 0;
                Block4.YCooridnate = Block4.YCooridnate + 2;
                
                _tetrisObjectService.CheckIfInBorder(Block1, Block2, Block3, Block4);

                break;
            case 180:
                Block1.XCooridnate = Block1.XCooridnate + 1;
                Block1.YCooridnate = Block1.YCooridnate + 1;
                //Block2.XCooridnate = Block2.XCooridnate + 0;
                //Block2.YCooridnate = Block2.YCooridnate + 0;
                Block3.XCooridnate = Block3.XCooridnate - 1;
                Block3.YCooridnate = Block3.YCooridnate - 1;
                Block4.XCooridnate = Block4.XCooridnate - 2;
                //Block4.YCooridnate = Block4.YCooridnate + 0;
                _tetrisObjectService.CheckIfInBorder(Block1, Block2, Block3, Block4);

                break;
            case 270:
                Block1.XCooridnate = Block1.XCooridnate - 1;
                Block1.YCooridnate = Block1.YCooridnate + 1;
                //Block2.XCooridnate = Block2.XCooridnate + 0;
                //Block2.YCooridnate = Block2.YCooridnate + 0;
                Block3.XCooridnate = Block3.XCooridnate + 1;
                Block3.YCooridnate = Block3.YCooridnate - 1;
                Block4.XCooridnate = Block4.XCooridnate + 0;
                Block4.YCooridnate = Block4.YCooridnate - 2;
                _tetrisObjectService.CheckIfInBorder(Block1, Block2, Block3, Block4);

                break;
        }
    }
}