namespace ConsoleTetris.Shapes;

public class TetrisObjectService : ITetrisObject
{
    public void MoveLeft(Block block1, Block block2, Block block3, Block block4)
    {
        if (block1.XCooridnate != 0 && block2.XCooridnate != 0 && block3.XCooridnate != 0 && block4.XCooridnate != 0)
        {
            block1.XCooridnate--;
            block2.XCooridnate--;
            block3.XCooridnate--;
            block4.XCooridnate--;
        }
    }
    
    public void MoveRight(Block block1, Block block2, Block block3, Block block4)
    {
        if (block1.XCooridnate != Globals.WIDTH - 1 && block2.XCooridnate != Globals.WIDTH - 1 &&
            block3.XCooridnate != Globals.WIDTH - 1 && block4.XCooridnate != Globals.WIDTH - 1)
        {
            block1.XCooridnate++;
            block2.XCooridnate++;
            block3.XCooridnate++;
            block4.XCooridnate++;
        }
    }
    
    public void CheckIfInBorder(Block block1, Block block2, Block block3, Block block4)
    {
                if (block1.XCooridnate >= Globals.WIDTH || block2.XCooridnate >= Globals.WIDTH ||
                    block3.XCooridnate >= Globals.WIDTH || block4.XCooridnate >= Globals.WIDTH)
                {
                    MoveLeft(block1, block2, block3, block4);
                }

                if (block1.XCooridnate <= 0 || block2.XCooridnate <= 0 ||
                    block3.XCooridnate <= 0 || block4.XCooridnate <= 0)
                {
                    MoveRight(block1, block2, block3, block4);
                }
        
    }


    public void MoveDown()
    {
        throw new NotImplementedException();
    }
}