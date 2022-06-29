using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts
{
    internal class JumpController //: IDisposable
    {
      //private readonly ICanJump _jumper;
        private readonly IBall _ball;
      //private readonly bool _isBallUseJump;
        private readonly float _jumpForce;
       // private TriggerSubscribersController _triggerSubscribersController;

        internal JumpController(IBall ball)
        {
           // _jumper = jumper;
            _ball = ball;
          //  _isBallUseJump = true;
            //if(_ball == _jumper)
            //{
            //    _ball.SubscribeOnGroundHit();
            //}

            _jumpForce = 20;
            //_triggerSubscribersController = triggerSubscribersController;
            //_triggerSubscribersController.Register(8, OnGroundHit);
        }

        //public void Update(float deltaTime)
        //{
        //    if (_ball == _jumper && !_isBallUseJump)
        //    {
        //        _ball.UnsubscribeOnGroundHit();
        //    }
        //}

        public void OnGroundHit()
        {
            _ball.Jump(_jumpForce);
            Debug.LogError("ACTION OnGroundHit");
        }

        //public void Dispose()
        //{
        //    _triggerSubscribersController.Unregister(8, OnGroundHit);
        //}
    }
}
