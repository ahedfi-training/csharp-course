using System;

namespace Stopwatch
{
    public class Stopwatch
    {
        private DateTime _start;
        private DateTime _end;
        private bool _isStarted = false;

        public void Start()
        {
            if (_isStarted)
                throw new InvalidOperationException("Stopwatch is already running !");
            _start = DateTime.Now;
            _isStarted = true;
        }

        public void Stop()
        {
            _end = DateTime.Now;
            _isStarted = false;
        }

        public TimeSpan Duration
        {
            get
            {
                return _end - _start;
            }
        }
    }
}
