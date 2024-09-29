using ConsoleTetris.Shapes;

namespace ConsoleTetris;

class Program
{
    static void Main(string[] args)
    {
        List<Block> blocks = new List<Block>();
        MapGen map = new MapGen(blocks);
        bool movingBlocks = false;
        //Array colorEnumValues = Enum.GetValues(typeof(ColorEnum));
        //Random random = new Random();
        
        while (true)
        {
            map.PrintMap();
            foreach (var block in blocks)
            {
                block.Gravity(blocks);
                if (block.State == StateEnum.Moving)
                {
                    movingBlocks = true;
                }
            }

            if (!movingBlocks)
            {
                ITetrisObject randomShape = RandomShapePicker.PickRandomShape(1, 0);
                blocks.Add(randomShape.Block1);
                blocks.Add(randomShape.Block2);
                blocks.Add(randomShape.Block3);
                blocks.Add(randomShape.Block4); 
            }

            movingBlocks = false;
            Thread.Sleep(100);
        }
    }
}