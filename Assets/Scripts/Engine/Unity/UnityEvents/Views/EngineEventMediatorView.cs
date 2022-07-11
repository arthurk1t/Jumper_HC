using System;
using UnityEngine;

namespace Engine.UnityEvent
{
    public class EngineEventMediatorView : MonoBehaviour
    {
        private Action<float> _update;
        private Action<float> _fixedUpdate;
        private Action<float> _lateUpdate;

        public void Listen(Action<float> update, Action<float> fixedUpdate, Action<float> lateUpdate)
        {
            _update = update;
            _fixedUpdate = fixedUpdate;
            _lateUpdate = lateUpdate;
        }

        public void UnlistenAll()
        {
            _update = null;
            _fixedUpdate = null;
            _lateUpdate = null;
        }

        public void SetDontDestroy()
        {
            DontDestroyOnLoad(gameObject);
        }

        private void Awake()
        {
            //gameObject.hideFlags = HideFlags.HideInHierarchy;
        }

        private void Update()
        {
            _update?.Invoke(Time.deltaTime);
        }

        private void FixedUpdate()
        {
            _fixedUpdate?.Invoke(Time.deltaTime);
        }

        private void LateUpdate()
        {
            _lateUpdate?.Invoke(Time.deltaTime);
        }
    }
}