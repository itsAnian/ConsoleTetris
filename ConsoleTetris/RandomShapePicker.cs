using System.Reflection;
using ConsoleTetris.Shapes;

namespace ConsoleTetris
{
    public static class RandomShapePicker
    {
        private static Random random = new Random();

        public static ITetrisObject PickRandomShape(int xCoordinate, int yCoordinate)
        {
            var shapeTypes = Assembly.GetExecutingAssembly()
                .GetTypes()
                .Where(t => typeof(ITetrisObject).IsAssignableFrom(t) && !t.IsInterface && !t.IsAbstract)
                .ToArray();

            if (shapeTypes.Length == 0)
            {
                throw new InvalidOperationException("No shapes found.");
            }

            var randomShapeType = shapeTypes[random.Next(shapeTypes.Length)];
            return (ITetrisObject)Activator.CreateInstance(randomShapeType, xCoordinate, yCoordinate);
        }
    }
}