using System.Collections.Generic;
using Zenject;

namespace Engine.UnityEvent
{
    public class EngineEventSceneMediator : EngineEventMediator
    {
        public EngineEventSceneMediator(
            [Inject(Optional = true, Source = InjectSources.Local)] List<IUpdatable> updatables,
            [Inject(Optional = true, Source = InjectSources.Local)] List<ILateUpdatable> lateUpdatables,
            [Inject(Optional = true, Source = InjectSources.Local)] List<IFixedUpdatable> fixedUpdatables)
            : base(updatables, lateUpdatables, fixedUpdatables)
        {
        }
    }
}