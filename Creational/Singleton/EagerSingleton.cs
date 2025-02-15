

public class EagerSingleton
{
    private static readonly EagerSingleton _instance = new EagerSingleton();

    private EagerSingleton() { }
    
    public static EagerSingleton GetInstance() => _instance;
}