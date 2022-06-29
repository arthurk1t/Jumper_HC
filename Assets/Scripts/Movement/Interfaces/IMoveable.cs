using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts
{
    internal interface IMoveable : IHavePosition
    {
        public float Speed { get; }
        public Transform Transform { get; }
    }
}
