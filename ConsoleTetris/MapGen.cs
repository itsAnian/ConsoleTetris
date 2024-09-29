using System.Collections;
using System.Text;

namespace ConsoleTetris;

public class MapGen
{
    private List<Block> blocks = new List<Block>();

    public MapGen(List<Block> blocks)
    {
        this.blocks = blocks;
    }

    public void PrintMap()
    {
        StringBuilder stringBuilder = new StringBuilder();
        Console.Clear();
        for (int y = 0; y < Globals.HIGHT; y++)
        {
            for (int x = 0; x < Globals.WIDTH; x++)
            {
                bool blockFound = false;

                foreach (var block in blocks)
                {
                    if (block.XCooridnate == x && block.YCooridnate == y)
                    {
                        stringBuilder.Append(block.PrintBlock());
                        blockFound = true;
                        break;
                    }
                }

                if (!blockFound)
                {
                    Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), ColorEnum.White.ToString());
                    stringBuilder.Append('.');
                }
            }
            stringBuilder.Append('\n');
        }
        string map = stringBuilder.ToString();
        Console.Write(map);
    }
}