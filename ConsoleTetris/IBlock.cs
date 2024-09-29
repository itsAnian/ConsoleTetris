namespace ConsoleTetris;

public interface IBlock
{
    public void PrintBlock();
    public void Gravity(List<Block> blocks);
}