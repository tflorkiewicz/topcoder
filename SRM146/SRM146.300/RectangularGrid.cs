
public class RectangularGrid
{
    public long countRectangles(int width, int height)
    {
        long result = 0;
        for (int i = 1; i <= width; i++)
        {
            for (int j = 1; j <= height; j++)
            {
                if (i==j) continue;

                result += (width - i + 1)*(height - j + 1);

            }
        }

        return result;
    }

}

