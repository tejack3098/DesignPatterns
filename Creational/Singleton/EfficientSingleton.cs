

public class EfficientSingleton
{
    private static volatile EfficientSingleton _instance;
    private static readonly object _lock = new object();

    private EfficientSingleton() { }

    public static EfficientSingleton GetInstance()
    {
        if (_instance == null) // First check without locking
        {
            lock (_lock)
            {
                if (_instance == null) // Second check with locking
                {
                    _instance = new EfficientSingleton();
                }
            }
        }

        return _instance;
    }
}