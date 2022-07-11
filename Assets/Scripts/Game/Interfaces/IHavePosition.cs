using UnityEngine;

namespace Assets.Scripts
{
    internal interface IHavePosition
    {
        public Vector2 Position { get; }
        public Quaternion Rotation { get; }
        void SetPosition(Vector2 position);
        void SetRotation(Vector3 transform);
    }
}
