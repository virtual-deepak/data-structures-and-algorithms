namespace CodingProblems;

public static class CanAttendMeetings
{
    public static bool Execute(List<List<int>> intervals)
    {
        intervals = intervals.OrderBy(x => x[0]).ToList();

        for (int i = 0; i < intervals.Count - 1; i++)
        {
            if (intervals[i][1] > intervals[i + 1][0])
                return false; 
        }
        return true;
    }
}