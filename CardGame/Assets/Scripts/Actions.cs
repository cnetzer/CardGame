using System;
using UnityEngine;

public static class Actions
{
    public static Action<GameEventContext> OnLoadScene, OnGameStart, OnRoundStart, OnPause, OnMute;
}

[Serializable]
public class GameEventContext
{
    public int intValue;
    public float floatValue;
    public string stringValue;
    public Vector3 vectorValue;

    public GameEventContext(int value)
    {
        intValue = value;
    }
    
    public GameEventContext(float value)
    {
        floatValue = value;
    }
    
    public GameEventContext(string value)
    {
        stringValue = value;
    }
    
    public GameEventContext(Vector3 value)
    {
        vectorValue = value;
    }
    
    public GameEventContext(string value, Vector3 vector)
    {
        stringValue = value;
        vectorValue = vector;
    }
}