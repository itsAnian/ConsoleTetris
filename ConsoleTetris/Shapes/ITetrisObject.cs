namespace ConsoleTetris.Shapes;

public interface ITetrisObject
{
    public Block Block1 { get; set; }
    public Block Block2 { get; set; }
    public Block Block3 { get; set; }
    public Block Block4 { get; set; }
    
    public void GetPosition();
    public void Turn();
}