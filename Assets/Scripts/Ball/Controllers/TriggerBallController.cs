using System;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts
{
    internal class TriggerBallController //: IDisposable
    {
        private readonly Dictionary<int, Action> _onTriggerSubscribers;
        private readonly IBall _ball;

        internal TriggerBallController(IBall ball)
        {
            _onTriggerSubscribers = new Dictionary<int, Action>();
            _ball = ball;
            _ball.BallView.OnTriggerEnterEvent += OnTriggerEnter;
            Register(8, _ball.OnGroundHit);
            //Register(1, _ball.OnObstacleHit);
        }

        public void Register(int key, Action onEvent)
        {
            if (_onTriggerSubscribers.ContainsKey(key)) _onTriggerSubscribers[key] += onEvent;
            else _onTriggerSubscribers[key] = onEvent;
        }

        public void Unregister(int key, Action onEvent)
        {
            _onTriggerSubscribers[key] -= onEvent;
        }
        
        private void OnTriggerEnter(Collider other)
        {
            var keyInt = other.gameObject.layer;
            _onTriggerSubscribers.TryGetValue(keyInt, out var handler);
            handler?.Invoke(); 
        }
    }
}
