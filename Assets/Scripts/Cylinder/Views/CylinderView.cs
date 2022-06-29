using UnityEngine;

namespace Assets.Scripts
{
    public class CylinderView : MonoBehaviour, ICylinderView
    {
        public Transform ViewTransform => _viewTransform;

        [SerializeField] private Transform _viewTransform;

        public void SetEnable(bool isEnable)
        {
            gameObject.SetActive(isEnable);
        }
    }
}
