namespace SnapPointProblem;

public interface ISnapPointCalculator
{
    IEnumerable<Position> CalculateSnapPoints(Position topLeftCorner, Dimensions dimensions);
}