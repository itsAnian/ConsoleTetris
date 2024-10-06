using ConsoleTetris.Shapes;

namespace ConsoleTetris;

class Program
{
    static void Main(string[] args)
    {
        List<Block> blocks = new List<Block>();
        MapGen map = new MapGen(blocks);
        bool blockOrFloorBelow = true;

        while (true)
        {
            map.PrintMap();
            blocks.Sort((block1, block2) => block1.YCooridnate.CompareTo(block2.YCooridnate));

            foreach (var block in blocks)
            {
                if (block.HasBlockOrFloorBelow(blocks))
                {
                    blockOrFloorBelow = true;
                    break;
                }
                else
                {
                    blockOrFloorBelow = false;
                }
            }

            if (blockOrFloorBelow)
            {
                foreach (var block in blocks)
                {
                    block.State = StateEnum.Stationary;
                }
                ITetrisObject randomShape = RandomShapePicker.PickRandomShape(1, 0);
                blocks.Add(randomShape.Block1);
                blocks.Add(randomShape.Block2);
                blocks.Add(randomShape.Block3);
                blocks.Add(randomShape.Block4);
            }
            else
            {
                foreach (var block in blocks)
                {
                    block.Gravity();
                }
            }

            Thread.Sleep(1000);
        }
    }
}