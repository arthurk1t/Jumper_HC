using UnityEngine;

namespace Assets.Scripts
{
    internal interface IView
    {
        public Transform ViewTransform { get; }

        void SetEnable(bool isEnable);
    }
}
