
public class IDGenerator
{
    private static IDGenerator instance = new IDGenerator();
    private static int validID = 0;
    public static IDGenerator GetInstance()
    {
        return instance;
    }

    public int GetValidID()
    {
        validID++;
        return validID;
    }
}