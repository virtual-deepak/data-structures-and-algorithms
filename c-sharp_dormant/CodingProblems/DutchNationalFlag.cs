namespace CodingProblems;

public static class DutchNationalFlag
{
    public static List<char> Execute(List<char> balls)
    {
        var r = 0;
        var g = 0;
        var b = balls.Count - 1;

        while (g <= b)
        {
            if (balls[g] == 'R')
            {
                Swap(balls, r, g);
                r++;
                g++;
            }
            else if (balls[g] == 'G')
                g++;
            else
            {
                Swap(balls, g, b);
                b--; 
                // Do not decrement g as its not sure whether the swapped ball is R or G yet at g.
            }
        }
        return balls;
    }

    public static void Swap(List<char> balls, int i, int j)
    {
        var temp = balls[i];
        balls[i] = balls[j];
        balls[j] = balls[i];
    }
}