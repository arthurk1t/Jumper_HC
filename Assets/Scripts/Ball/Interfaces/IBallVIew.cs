using System;
using UnityEngine;

namespace Assets.Scripts
{
    internal interface IBallView : IView
    {
        public event Action<Collider> OnTriggerEnterEvent;
        public Rigidbody BallViewRigidbody { get; }
        public MeshRenderer BallViewMesh { get; }
    }
}
