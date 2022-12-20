/*
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public static class GameEventBus
{
    private static readonly IDictionary<GameEventType, UnityEvent<GameEventContext>>
        Events = new Dictionary<GameEventType, UnityEvent<GameEventContext>>();

    public static void Register(GameEventType eventType, UnityAction<GameEventContext> listener)
    {
        if (Events.TryGetValue(eventType, out var thisEvent))
        {
            thisEvent.AddListener(listener);
        }
        else
        {
            thisEvent = new UnityEvent<GameEventContext>();
            thisEvent.AddListener(listener);
            Events.Add(eventType, thisEvent);
        }
    }

    public static void UnRegister(GameEventType eventType, UnityAction<GameEventContext> listener)
    {
        if (Events.TryGetValue(eventType, out var thisEvent))
        {
            thisEvent.RemoveListener(listener);
            Events.Remove(eventType);
        }
    }

    public static void Raise(GameEventType eventType, GameEventContext ctx)
    {
        if (Events.TryGetValue(eventType, out var thisEvent))
        {
            thisEvent?.Invoke(ctx);
        }
    }
}
*/


