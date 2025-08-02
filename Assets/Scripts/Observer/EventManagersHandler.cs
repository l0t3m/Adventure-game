using System;
using System.Collections.Generic;
using UnityEngine;

public class EventManagersHandler
{
    Dictionary<string, EventManager> eventManagers = new Dictionary<string, EventManager>();

    public void CreateEventManager(string managerName, EventManager manager)
    {
        if (eventManagers.ContainsKey(managerName)) return;
        eventManagers.Add(managerName, manager);
    }

    public void Attach(string managerName, IEventListeners listener)
    {
        if (!eventManagers.ContainsKey(managerName)) return;
        eventManagers[managerName].Attach(listener);
    }

    public void Detach(string managerName, IEventListeners listener)
    {
        if (!eventManagers.ContainsKey(managerName)) return;
        eventManagers[managerName].Detach(listener);
    }

    public void Notify(string managerName)
    {
        if (!eventManagers.ContainsKey(managerName)) return;
        eventManagers[managerName].Notify();
    }

    public void DoLogic(string managerName, params object[] args)
    {
        if (!eventManagers.ContainsKey(managerName)) return;
        eventManagers[managerName].DoLogic(args);
    }
}
