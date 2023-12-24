public class Solution {
    public int MaxWidthOfVerticalArea(int[][] points) {
        points = points.OrderBy(point => point[0]).ToArray();
        int max = 0;
        for (int i = 0; i < (points.Length - 1); i++) {
            int xCoordinate = points[i][0];
            int xCoordinateProx = points[i + 1][0];
            int verticalCount = Math.Abs(xCoordinate - xCoordinateProx);
            if (verticalCount > max)
                max = verticalCount;
        }
        return max;
    }
}
