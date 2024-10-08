namespace ConsoleTetris.Shapes;

public interface IShape
{
    public Block Block1 { get; set; }
    public Block Block2 { get; set; }
    public Block Block3 { get; set; }
    public Block Block4 { get; set; }
    public int RotationState { get; set; }

    public void Turn();
}