namespace Assets.Scripts
{
    internal interface IBall : ICanJump, IAlive
    {
        public IBallView BallView { get; }

        void OnGroundHit();
        void OnObstacleHit();
    }
}
