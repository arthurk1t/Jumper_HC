using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public void Update(float deltaTime)
        {
            GameState state = GameState.START;
        }
    }
}
