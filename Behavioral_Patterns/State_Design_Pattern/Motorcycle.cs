using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_Design_Pattern
{
    public class Motorcycle : IState
    {
        private IState _state;
        public Motorcycle(IState state)
        {
            this._state = state;
        }
        public IState getState(IState state)
        {
            return _state= state;   
        }
        public void DoAction()
        {
            _state.DoAction();
        }
    }
}
