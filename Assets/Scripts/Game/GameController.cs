using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.UnityEvent;

namespace Assets.Scripts.Common
{
    public enum GameState 
    {
        START,
        PAUSE,
        GAME_OVER
    }

    internal class GameController : IUpdatable
    {
        internal GameController()
        {

        }

        public void CustomUpdate(float deltaTime)
        {
           // GameState state = GameState.START;
        }
    }
}
