namespace ConsoleTetris;

public interface IBlock
{
    public char PrintBlock();
    public bool Gravity();
    public bool HasBlockOrFloorBelow(List<Block> blocks);
}