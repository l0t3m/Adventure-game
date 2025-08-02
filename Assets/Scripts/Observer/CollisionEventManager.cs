using UnityEngine;

public class CollisionEventManager : EventManager
{
    public GameObject CollisionGO;
    public override void Attach(IEventListeners listener)
    {
        base.Attach(listener);
    }

    public override void Detach(IEventListeners listener)
    {
        base.Detach(listener);
    }

    public override void Notify()
    {
        foreach (IEventListeners listener in EventListeners)
        {
            listener.Execute(this);
        }
    }

    public override void DoLogic(params object[] args)
    {
        if (args[0] is GameObject obj)
            CollisionGO = obj;
    }
}
