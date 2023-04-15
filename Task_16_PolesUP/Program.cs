internal class Program
{
    private static void Main(string[] args)
    {
        int n = 108;//27+81
        Console.WriteLine(IsTheSumOfDegrees(n));
        int n2 = 105;
        Console.WriteLine(IsTheSumOfDegrees(n2));
    }

    public static bool IsTheSumOfDegrees(int n) 
    {
        if(n%3!=0)return false;
        int firstDegree= (int)Math.Round(Math.Log(n, 3));
        int secondDegree = (int)Math.Round(Math.Log(n - Math.Pow(3, firstDegree), 3));
        Console.WriteLine(Math.Pow(3, firstDegree) + Math.Pow(3, secondDegree));
        if (Math.Pow(3,firstDegree) + Math.Pow(3,secondDegree) == n) return true;
        else return false;
    }
}