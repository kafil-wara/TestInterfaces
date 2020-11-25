using System;
using System.Collections.Generic;
using System.Text;

namespace TestInterface3
{
    class Phone : IMusicPlayer, IRadioPlayer
    {
        public void changeChannel()
        {
            throw new NotImplementedException();
        }

        public void onOff(bool on)
        {
            throw new NotImplementedException();
        }

        public void onOff(bool on)
        {
            throw new NotImplementedException();
        }

        public void play(bool on)
        {
            throw new NotImplementedException();
        }

        public void playNext()
        {
            throw new NotImplementedException();
        }

        public void playPrevious()
        {
            throw new NotImplementedException();
        }

        public void retune(double frequency)
        {
            throw new NotImplementedException();
        }

        public void setVolume(int loudness)
        {
            throw new NotImplementedException();
        }
    }
}
