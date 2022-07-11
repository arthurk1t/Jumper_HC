using System;

namespace Engine.UnityEvent
{
    public interface IEngineEventMediator
    {
        event Action<float> OnUpdate;
        event Action<float> OnFixeedUpdate;

        void Register(IUpdatable updatable);
        void Register(IFixedUpdatable fixedUpdatable);

        void UnRegister(IUpdatable updatable);
        void UnRegister(IFixedUpdatable fixedUpdatable);
    }
}