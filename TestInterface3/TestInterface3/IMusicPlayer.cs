using System;
using System.Collections.Generic;
using System.Text;

namespace TestInterface3
{
    interface IMusicPlayer
    {
        void onOff(bool on);

        void play(bool on);

        void setVolume(int loudness);

        void playNext();

        void playPrevious();
    }
}
