using System;
using UnityEngine;

namespace Assets.Scripts
{
    public class BallView : MonoBehaviour, IBallView
    {
        public event Action<Collider> OnTriggerEnterEvent;

        public Rigidbody BallViewRigidbody => _ballViewRigidbody;
        public MeshRenderer BallViewMesh => _ballViewMesh;
        public Transform ViewTransform => _viewTransform;

        [SerializeField] private Rigidbody _ballViewRigidbody;
        [SerializeField] private MeshRenderer _ballViewMesh;
        [SerializeField] private Transform _viewTransform;

        public void SetEnable(bool isEnable)
        {
           gameObject.SetActive(isEnable);
        }

        private void OnTriggerEnter(Collider other)
        {
            OnTriggerEnterEvent?.Invoke(other);
        }
    }
}
