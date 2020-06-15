
public class IDGenerator
{
    private static IDGenerator instance = new IDGenerator();
    private static int validID = 1024;//1024以下为预留
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