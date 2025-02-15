
LazySingleton instance1 = LazySingleton.GetInstance();
LazySingleton instance2 = LazySingleton.GetInstance();

Console.WriteLine("Same instance?");
Console.WriteLine(instance1 == instance2);