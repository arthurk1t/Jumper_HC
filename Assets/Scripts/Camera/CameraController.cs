using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.UnityEvent;
using UnityEngine;

namespace Assets.Scripts
{
    internal class CameraController : IUpdatable
    {
        private readonly Camera _camera;
        private readonly Transform _targetTransform;

        internal CameraController(Camera camera, Transform targetTransform)
        {
            _camera = camera;
            _targetTransform = targetTransform;
        }

        public void CustomUpdate(float deltaTime)
        {
            if(_targetTransform.position.y < 0)
            {

            }
        }

        private Vector2 FollowTarget(Transform targetTranssform)
        {
            var targetPosition = Vector3.Lerp(_camera.transform.position, targetTranssform.position, 20);
            return targetPosition;
        }

        private void SetPosition(Vector2 position)
        {
            _camera.transform.position = position;  
        }
    }
}
