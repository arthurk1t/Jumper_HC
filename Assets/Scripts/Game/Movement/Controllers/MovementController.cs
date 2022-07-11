using System.Collections.Generic;
using UnityEngine;
using Engine.UnityEvent;

namespace Assets.Scripts
{
    internal class MovementController : IUpdatable
    {
        private readonly float _cylinderOffset = 15.0f;
        private readonly IReadOnlyList<IMoveable> _moveableObjects;

        internal MovementController(List<IMoveable> moveableObjects)
        {
            _moveableObjects = moveableObjects;
        }

        private Vector3 GetCylinderRotation(IMoveable moveableObject)
        {
            Vector3 rotatePosition = moveableObject.Position;

            //if (Application.platform == RuntimePlatform.Android || Application.platform == RuntimePlatform.IPhonePlayer)
            //{

            if (Input.touchCount == 1)
            {
                bool swipe = false;
                var startPositionX = Input.GetAxis("Mouse X");

                if (Input.GetTouch(0).phase == TouchPhase.Began || Input.GetTouch(0).phase == TouchPhase.Stationary)
                {
                    swipe = true;
                }
                else if (Input.GetTouch(0).phase == TouchPhase.Ended)
                {
                    swipe = false;
                }

                if (swipe)
                {
                    rotatePosition = new Vector3(0, (Input.GetAxis("Mouse X") - startPositionX) * -1, 0) * moveableObject.Speed * Time.deltaTime;
                }
            }

            if (Input.GetMouseButton(0))
            {
                Debug.Log("GetBTN");
                rotatePosition = new Vector3(0, Input.GetAxis("Mouse X") * -1, 0) * moveableObject.Speed * Time.deltaTime;
            }

            //  }
            return rotatePosition;
        }

        private Vector2 RepositionCylinder(IMoveable moveableObject)
        {
            while (true)
            {
                var cylinderPosition = new Vector2(moveableObject.Position.x, moveableObject.Position.y + _cylinderOffset);
                return cylinderPosition;
            }
        }

        public void CustomUpdate(float deltaTime)
        {
            Debug.LogError("UPDATEMOVCONTR");

            foreach (var moveableObject in _moveableObjects)
            {
                ////if (moveableObject.Equals(typeof(ICylinder)))
                //var cylinderPosition = RepositionCylinder(moveableObject);
                //moveableObject.SetPosition(cylinderPosition);

                var cylinderRotation = GetCylinderRotation(moveableObject);
                moveableObject.SetRotation(cylinderRotation);
            }
        }
    }
}
