using FluentAssertions;
using SnapPointProblem;

namespace SnapPointProblemTests;

public class SnapPointCalculatorTests
{
    private readonly SnapPointCalculator _snapPointCalculator;
    
    public SnapPointCalculatorTests()
    {
        _snapPointCalculator = new SnapPointCalculator();
    }
    
    [Fact]
    public void CalculateSnapPoints()
    {
        // Arrange
        Position topLeftCorner = new() { X = 101f, Y = 106f };
        Dimensions dimensions = new Dimensions() { Width = 130f, Height = 90f };
        Position[] expectedSnapPoints =
        [
            // Top Side
            new Position { X = 120f, Y = 100f },
            new Position { X = 140f, Y = 100f },
            new Position { X = 160f, Y = 100f },
            new Position { X = 180f, Y = 100f },
            new Position { X = 200f, Y = 100f },
            
            // Bottom Side
            new Position { X = 140f, Y = 190f },
            new Position { X = 160f, Y = 190f },
            new Position { X = 180f, Y = 190f },
            new Position { X = 200f, Y = 190f },
          
            // Right Side
            new Position { X = 225f, Y = 125f },
            new Position { X = 225f, Y = 145f },
            new Position { X = 225f, Y = 165f },

            // Left Side
            new Position { X = 95f, Y = 125f },
            new Position { X = 95f, Y = 145f }
        ];
        
        // Act
        Position[] actualSnapPoints = _snapPointCalculator.CalculateSnapPoints(topLeftCorner, dimensions).ToArray();

        // Assert
        actualSnapPoints.Length.Should().Be(expectedSnapPoints.Length);
        foreach (Position expectedPoint in expectedSnapPoints)
        {
            actualSnapPoints.Should().Contain(s =>
                s.X.IsApproximatelyEqualTo(expectedPoint.X) && s.Y.IsApproximatelyEqualTo(expectedPoint.Y));
        }
    }
}