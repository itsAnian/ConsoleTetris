namespace ConsoleTetris.Shapes;

public interface ITetrisObject
{
    public void MoveLeft(Block block1, Block block2, Block block3, Block block4);
    public void MoveRight(Block block1, Block block2, Block block3, Block block4);
    public void MoveDown();
}