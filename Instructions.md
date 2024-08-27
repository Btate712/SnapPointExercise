# Instructions

We need code that determines where to put "snap points"
on rectangles drawn in our application. These snap points 
are the locations where other objects are allowed to connect
to the rectangles. 

To make it easy to determine whether the code you've written
is correct, there is a unit test that contains a test case
which exercises all the logical rules that need to be followed.

# Rules
- Your code must be in the `CalculateSnapPoints` method of the
`SnapPointCalculator` class (you may not change the method
signature as this would break the test).
- The `CalculateSnapPoints` method accepts parameters for the 
top-left corner `Position` (X and Y coordinates) of a rectangle, 
along with the `Dimensions` (Width and Height) of the rectangle.
- The coordinate system used has X coordinates increasing from
left to right, and Y coordinates increasing from top to bottom.
- The `Position` and `Dimensions` provided will be chosen such
that at least one snap point should be found for each side of
the described rectangle.
- One snap point should exist in the center of each side of the 
supplied rectangle.
- The centers of each snap point on a side should be separated by 
a value equal to the `SnapPointSeparation` constant.
- When a snap point is displayed (using frontend code), a circle 
with a radius equal to `PointRadius` will be drawn around the snap 
point.
  - All edges of this circle must be separated from the side of the
  rectangle by a buffer of at least `SnapPointCornerBuffer`.
  - There is a label drawn in the bottom-left corner of the
  rectangle. For this reason, there must be an additional buffer
  in the bottom-left corner of `SnapPointAdditionalLabelBuffer`.
- You may inspect any/all of the provided code, but you may NOT 
change the test code.
- You may ask as many questions as you need to understand the
problem.
- You may be allowed to use external sources/tools to help solve 
the problem, but you must ask before doing so.
  
# Constant Values
- PointRadius: 6
- SnapPointSeparation: 20
- SnapPointCornerBuffer: 10
- SnapPointAdditionalLabelBuffer: 10

