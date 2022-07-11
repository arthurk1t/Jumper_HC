using System;

namespace Engine.Mediators
{
    public interface IInitializeMediator
    {
        event Action OnDone;
    }
}