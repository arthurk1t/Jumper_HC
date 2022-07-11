using System.Collections.Generic;

namespace Engine.UnityEvent
{
    public class EngineEventProjectMediator : EngineEventMediator
    {
        public EngineEventProjectMediator(List<IUpdatable> updatables, List<ILateUpdatable> lateUpdatables,
            List<IFixedUpdatable> fixedUpdatables)
            : base(updatables, lateUpdatables, fixedUpdatables)
        {
            _unityEventMediatorView.SetDontDestroy();
        }
    }
}