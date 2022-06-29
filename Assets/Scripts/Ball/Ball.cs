using System;
using UnityEngine;

namespace Assets.Scripts
{
    internal class Ball : IBall
    {
        public IBallView BallView => _ballView;
        public Vector2 Position => _ballView.ViewTransform.position;
        public Quaternion Rotation => _ballView.ViewTransform.rotation;
        public int Hp { get => _hp; set { _hp = value; } }

        private readonly IBallView _ballView;
        private readonly float _jumpForce;
        private int _hp;
        
        internal Ball(IBallView ballView)
        {
            _ballView = ballView;
            _jumpForce = 20.0f;
            _hp = 1;
        }

        public void Jump(float jumpForce)
        {
            _ballView.BallViewRigidbody.AddRelativeForce(Vector3.up * jumpForce, ForceMode.Impulse);
            Debug.LogError($"JUMP!");
        }

        public void TakeDamage(int damage = 1)
        {
            if (damage < 1)
                return;

            _hp -= damage;
        }

        public void OnGroundHit()
        {
            Jump(_jumpForce);
            Debug.LogError("ACTION => OnGroundHit");
        }

        public void OnObstacleHit()
        {
           TakeDamage();
           Debug.LogError("ACTION  => OnObstacleHit");
        }

        public void SetColor(Color color)
        {
            throw new NotImplementedException();
        }

        public void SetPosition(Vector2 position)
        {
            throw new NotImplementedException();
        }

        public void SetRotation(Vector3 transform)
        {
            throw new NotImplementedException();
        }
    }
}
