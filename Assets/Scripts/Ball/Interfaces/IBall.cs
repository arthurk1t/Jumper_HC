using UnityEngine;

namespace Assets.Scripts
{
    internal interface IBall : ICanJump, IAlive
    {
        public IBallView BallView { get; }

        void SetColor(Color color);
        void OnGroundHit();
        void OnObstacleHit();
    }
}
