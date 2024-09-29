namespace ConsoleTetris;

public interface IBlock
{
    public char PrintBlock();
    public void Gravity(List<Block> blocks);
}