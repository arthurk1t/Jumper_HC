using System.Collections.Generic;
using UnityEngine;
using Zenject;

namespace Assets.Scripts
{
    public class UpdateMediator : ITickable
    {
        private readonly List<IUpdatable> _updatableObjects;

        public UpdateMediator(List<IUpdatable> updatableObjects)
        {
            _updatableObjects = updatableObjects;
        }

        private void Update(float deltaTime)
        {
            foreach (var updatableObject in _updatableObjects)
            {
                updatableObject?.Update(deltaTime);
            }
        }

        public void Tick()
        {
            Update(Time.deltaTime);
        }
    }
}