

public class BasicSingleton
{
    private static BasicSingleton _instance;
    
    // Private constructor to prevent direct instantiation
    private BasicSingleton() { }

    public static BasicSingleton GetInstance()
    {
        if (_instance == null)
        {
            _instance = new BasicSingleton();
        }

        return _instance;
    }
}