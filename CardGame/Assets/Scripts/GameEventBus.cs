using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

// ReSharper disable All

public static class GameEventBus
{
    private static readonly IDictionary<GameEventType, UnityEvent<GameEventContext>>
        _events = new Dictionary<GameEventType, UnityEvent<GameEventContext>>();
}

[System.Serializable]
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

public enum GameEventType
{
    OnGameStart,
    OnSceneLoad,
    OnPause,
    OnMute,
    OnRoundStart
}
