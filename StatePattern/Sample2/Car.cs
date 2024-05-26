using System;

namespace StatePattern.Sample2
{
    public class Car
    {
        public enum State
        {
            Stopped,
            Started,
            Running
        }
        
        public enum Action  
        {
            Stop,
            Start,
            Accelerate
        }

        private State _state = State.Stopped;
        
        public State CurrentState
        {
            get { return _state; }
        }

        public void TakeAction(Action action)
        {
            switch (_state)
            {
                case  State.Stopped:
                    switch (action)
                    {
                        case  Action.Start:
                            _state = State.Started;
                            break;
                    }
                    break;
                case State.Started:
                    switch (action)
                    {
                        case  Action.Accelerate:
                            _state = State.Running;
                            break;
                        
                        case  Action.Stop:
                            _state = State.Stopped;
                            break;
                    }
                    break;
                
                case State.Running:
                    switch (action)
                    {
                        case  Action.Stop:
                            _state = State.Stopped;
                            break;
                    }
                    break;
                
                default:
                    break;
            }
        }
        
        
    }
}