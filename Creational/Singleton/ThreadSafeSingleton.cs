

public class ThreadSafeSingleton
{
    private static volatile ThreadSafeSingleton _instance;

    private static readonly object _lock = new object();

    private ThreadSafeSingleton() { }

    public static ThreadSafeSingleton GetInstance()
    {
        lock (_lock)
        {
            if (_instance == null)
            {
                _instance = new ThreadSafeSingleton();
            }
        }
        return _instance;
    }
}