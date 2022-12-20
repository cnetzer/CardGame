using UnityEngine;

public abstract class Singleton<T>
{
    public static Singleton<T> Instance;

    public static void SetSingleton(Singleton<T> singleton)
    {
        Instance = singleton;
    }
}
