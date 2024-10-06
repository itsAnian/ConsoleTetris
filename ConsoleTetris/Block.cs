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

    public char PrintBlock()
    {
        Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), Color.ToString());
        char printBlock = '#';
        return printBlock;
    }

    public bool HasBlockOrFloorBelow(List<Block> blocks)
    {
        bool blockBelow = false;
        foreach (var block in blocks)
        {
            if (YCooridnate < Globals.HIGHT-1 && State == StateEnum.Moving)
            {
                if (block.YCooridnate == (YCooridnate + 1) && block.XCooridnate == XCooridnate &&
                    block.State == StateEnum.Stationary)
                {
                    blockBelow = true;
                    return blockBelow;
                }
            }
            else if (State == StateEnum.Moving)
            {
                Console.WriteLine("I would go out of map");
                blockBelow = true;
                return blockBelow;
            }
        }
        return blockBelow;
    }

    public bool Gravity()
    {
        bool moving = true;
        if (State == StateEnum.Moving)
        {
            YCooridnate++;
        }
        else
        {
            return false;
        }
        return moving;
    }
}