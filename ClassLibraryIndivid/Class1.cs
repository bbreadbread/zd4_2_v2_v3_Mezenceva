namespace ClassLibrary1
{
    public class ClassLibraryVotes
    {
        public static string Elections(string[] str)
        {
            if (str.Length > 0)
            {
                if (int.Parse(str[0]) % 2 == 1)
                {
                    if (str.Length - 2 == int.Parse(str[0]))
                    {
                        int N = int.Parse(str[0]);
                        int C = int.Parse(str[1]);
                        int allVotes = 0;

                        for (int i = 2; i <= N + 1; i++)
                        {
                            int P = int.Parse(str[i]);
                            int neededVotes = P / 2 + 1;
                            allVotes += neededVotes;
                        }

                        int totalCost = allVotes * C;

                        return totalCost.ToString();
                    }
                    else return "error 3";
                }
                else return "error 2";
            }
            else return "error 1";
        }
    }
    public class ClassLibraryFlowerbad
    {
        static int X1m { get; set; }
        static int X2m { get; set; }
        static int Y1m { get; set; }
        static int Y2m { get; set; }
        static int X1d { get; set; }
        static int X2d { get; set; }
        static int Y1d { get; set; }
        static int Y2d { get; set; }

        public static bool Check(string[] str)
        {
            if (str.Length == 8)
            {
                if (int.TryParse(str[0].ToString(), out int x1m) &&
                               int.TryParse(str[1].ToString(), out int y1m) &&
                               int.TryParse(str[2].ToString(), out int x2m) &&
                               int.TryParse(str[3].ToString(), out int y2m) &&
                               int.TryParse(str[4].ToString(), out int x1d) &&
                               int.TryParse(str[5].ToString(), out int y1d) &&
                               int.TryParse(str[6].ToString(), out int x2d) &&
                               int.TryParse(str[7].ToString(), out int y2d))
                {
                    X1m = x1m;
                    Y1m = y1m;
                    X2m = x2m;
                    Y2m = y2m;
                    X1d = x1d;
                    Y1d = y1d;
                    X2d = x2d;
                    Y2d = y2d;

                    return true;
                }
                else return false;
            }
            else return false;
        }
        public static int RectangleArea(string who_lower)
        {
            if (who_lower == "boys") return Math.Abs(X2m - X1m) * Math.Abs(Y2m - Y1m);
            else if (who_lower == "girls") return Math.Abs(X2d - X1d) * Math.Abs(Y2d - Y1d);
            else return 0;
        }
        public static int IntersectionArea()
        {
            int xLeft = Math.Max(X1m, X1d);
            int xRight = Math.Min(X2m, X2d);

            int yBottom = Math.Max(Y1m, Y1d);
            int yTop = Math.Min(Y2m, Y2d);

            if (xLeft < xRight && yBottom < yTop)
            {
                return (xRight - xLeft) * (yTop - yBottom);
            }
            return 0;
        }
    }
}
