class Program
{
    public static void Main()
    {
        int a = 3;
        int b = 4;
        bool c = true;
        string result = "";
        if (a < b)
        {
            result += "A";
        }
        else
        {
            result += "B";
        }

        if (a % 2 == 0 || b % 2 == 0)
        {
            result += "C";
        }
        if (!c)
        {
            result += "D";
        }
        if (a != b)
        {
            result += "E";
            if ((a + b * a) > 15)
            {
                result += "F";
            }
            else
            {
                result += "G";
            }
        }
    }
}