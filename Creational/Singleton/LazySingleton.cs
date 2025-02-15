

public class LazySingleton{

    //Uses lazy Initialization and thread safety without explicit locking
    private static readonly Lazy<LazySingleton> _instance = new Lazy<LazySingleton>(() => new LazySingleton());

    private LazySingleton() { }

    public static LazySingleton GetInstance() => _instance.Value;
}