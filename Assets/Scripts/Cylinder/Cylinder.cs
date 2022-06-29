using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts
{
    internal class Cylinder : ICylinder
    {
        public float Speed => _cylinderRotationSpeed;
        public Transform Transform => _cylinderView.ViewTransform;
        public Vector2 Position => _cylinderView.ViewTransform.position;
        public Quaternion Rotation => _cylinderView.ViewTransform.rotation;

        private readonly ICylinderView _cylinderView;
        private readonly float _cylinderRotationSpeed;

        public Cylinder(ICylinderView cylinderView)
        {
            _cylinderView = cylinderView;
            _cylinderRotationSpeed = 30.0f;
        }

        public void SetPosition(Vector2 position)
        {
            _cylinderView.ViewTransform.position = position;
        }

        public void SetRotation(Vector3 rotatePosition)
        {
            _cylinderView.ViewTransform.Rotate(rotatePosition);
        }
    }
}
