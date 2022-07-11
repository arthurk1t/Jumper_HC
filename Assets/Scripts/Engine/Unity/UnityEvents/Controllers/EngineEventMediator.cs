using System;
using System.Collections.Generic;
using UnityEngine;

namespace Engine.UnityEvent
{
    public abstract class EngineEventMediator : IDisposable
    {
        private readonly List<IUpdatable> _updatables;
        private readonly List<ILateUpdatable> _lateUpdatables;
        private readonly List<IFixedUpdatable> _fixedUpdatables;

        protected readonly EngineEventMediatorView _unityEventMediatorView;

        protected EngineEventMediator(List<IUpdatable> updatables, List<ILateUpdatable> lateUpdatables, List<IFixedUpdatable> fixedUpdatables)
        {
            _updatables = updatables;
            _lateUpdatables = lateUpdatables;
            _fixedUpdatables = fixedUpdatables;

            _unityEventMediatorView = new GameObject("UnityEventMediator").AddComponent<EngineEventMediatorView>();
            _unityEventMediatorView.Listen(Update, FixedUpdate, LateUpdate);
        }

        private void Update(float deltaTime)
        {
            foreach (var item in _updatables)
                item.CustomUpdate(deltaTime);
        }

        private void FixedUpdate(float deltaTime)
        {
            foreach (var item in _fixedUpdatables)
                item.CustomFixedUpdate(deltaTime);
        }

        private void LateUpdate(float deltaTime)
        {
            foreach (var item in _lateUpdatables)
                item.LateUpdate(deltaTime);
        }

        public void Dispose()
        {
            _unityEventMediatorView.UnlistenAll();
        }
    }
}