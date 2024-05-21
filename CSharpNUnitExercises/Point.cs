namespace CSharpNUnitExercises
{
    public struct Point(int x, int y)
    {
        public int X { get; } = x;
        public int Y { get; } = y;

        public double DistanceTo(Point other)
        {
            throw new NotImplementedException();
        }
    }
}