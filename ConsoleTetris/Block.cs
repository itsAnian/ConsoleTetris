namespace ConsoleTetris;

public class Block : IBlock
{
    public ColorEnum Color { get; set; }
    public int XCooridnate { get; set; }
    public int YCooridnate { get; set; }
    public StateEnum State { get; set; }

    public Block(ColorEnum color)
    {
        Color = color;
        XCooridnate = 0;
        YCooridnate = 0;
        State = StateEnum.Moving;
    }

    public Block(ColorEnum color, int xCooridnate, int yCooridnate)
    {
        Color = color;
        XCooridnate = xCooridnate;
        YCooridnate = yCooridnate;
        State = StateEnum.Moving;
    }

    public void PrintBlock()
    {
        Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), Color.ToString());
        Console.Write("#");
    }

    public void Gravity(List<Block> blocks)
    {
        bool blockfound = false;
        if (YCooridnate < (Globals.HIGHT - 1) && State == StateEnum.Moving)
        {
            foreach (var block in blocks)
            {
                if (block.YCooridnate == (YCooridnate + 1) && block.State == StateEnum.Stationary)
                {
                    foreach (var movingBlock in blocks)
                    {
                        movingBlock.State = StateEnum.Stationary;
                    }
                    blockfound = true;
                    break;
                }
            }

            if (!blockfound && State == StateEnum.Moving)
            {
                YCooridnate++;
            }
        }
        else if (State == StateEnum.Moving)
        {
            foreach (var movingBlock in blocks)
            {
                movingBlock.State = StateEnum.Stationary;
            }
        }
    }
}