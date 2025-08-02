using System.Collections.Generic;
using UnityEngine;

public class EventManager
{
    protected List<IEventListeners> EventListeners = new List<IEventListeners>();

    public virtual void Attach(IEventListeners listener)
    {
        if (listener != null)
            EventListeners.Add(listener);
    }

    public virtual void Detach(IEventListeners listener)
    {
        if (listener != null)
            EventListeners.Remove(listener);
    }

    public virtual void Notify()
    {
        foreach (IEventListeners listener in EventListeners)
        {
            listener.Execute(this);
        }
    }

    public virtual void DoLogic(params object[] args)
    {

    }
}
