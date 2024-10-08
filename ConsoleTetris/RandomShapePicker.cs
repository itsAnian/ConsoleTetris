using System.Reflection;
using ConsoleTetris.Shapes;

namespace ConsoleTetris
{
    public static class RandomShapePicker
    {
        private static Random random = new Random();

        public static IShape PickRandomShape(int xCoordinate, int yCoordinate)
        {
            var shapeTypes = Assembly.GetExecutingAssembly()
                .GetTypes()
                .Where(t => typeof(IShape).IsAssignableFrom(t) && !t.IsInterface && !t.IsAbstract)
                .ToArray();

            if (shapeTypes.Length == 0)
            {
                throw new InvalidOperationException("No shapes found.");
            }

            var randomShapeType = shapeTypes[random.Next(shapeTypes.Length)];
            return (IShape)Activator.CreateInstance(randomShapeType, xCoordinate, yCoordinate);
        }
    }
}