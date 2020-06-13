
public class Log
{
    public static void Print(string format,params object[] arg )
    {
        System.Console.Write(format, arg);
    }
}