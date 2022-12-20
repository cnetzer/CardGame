using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Singleton;

    private void Awake()
    {
        Singleton = this;
    }
}
