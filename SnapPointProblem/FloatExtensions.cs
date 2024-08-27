namespace SnapPointProblem;

public static class FloatExtensions
{
    public static bool IsApproximatelyEqualTo(this float a, float b)
    {
        const float precision = 0.001f;
        return Math.Abs(a - b) < precision;
    }
}