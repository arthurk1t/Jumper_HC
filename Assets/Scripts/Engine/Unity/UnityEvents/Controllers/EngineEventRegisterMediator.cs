using System;
using System.Collections.Generic;

namespace Engine.UnityEvent
{
    public class EngineEventRegisterMediator : IEngineEventMediator, IUpdatable, IFixedUpdatable, IDisposable
    {
        public event Action<float> OnUpdate;
        public event Action<float> OnFixeedUpdate;
        public event Action<bool> OnPause;

        private readonly List<IUpdatable> _updatables;
        private readonly List<IFixedUpdatable> _fixedUpdatables;

        public EngineEventRegisterMediator()
        {
            _updatables = new List<IUpdatable>();
            _fixedUpdatables = new List<IFixedUpdatable>();
        }

        public void Register(IUpdatable updatable)
        {
            if (!_updatables.Contains(updatable))
                _updatables.Add(updatable);
        }

        public void Register(IFixedUpdatable fixedUpdatable)
        {
            if (!_fixedUpdatables.Contains(fixedUpdatable))
                _fixedUpdatables.Add(fixedUpdatable);
        }

        public void UnRegister(IUpdatable updatable)
        {
            if (_updatables.Contains(updatable))
                _updatables.Remove(updatable);
        }

        public void UnRegister(IFixedUpdatable fixedUpdatable)
        {
            if (_fixedUpdatables.Contains(fixedUpdatable))
                _fixedUpdatables.Remove(fixedUpdatable);
        }

        public void CustomUpdate(float deltaTime)
        {
            for (int i = 0; i < _updatables.Count; i++)
                _updatables[i].CustomUpdate(deltaTime);

            OnUpdate?.Invoke(deltaTime);
        }

        public void CustomFixedUpdate(float deltaTime)
        {
            for (int i = 0; i < _fixedUpdatables.Count; i++)
                _fixedUpdatables[i].CustomFixedUpdate(deltaTime);

            OnFixeedUpdate?.Invoke(deltaTime);
        }

        public void Dispose()
        {
            OnUpdate = null;
            OnFixeedUpdate = null;

            _updatables.Clear();
            _fixedUpdatables.Clear();
        }
    }
}