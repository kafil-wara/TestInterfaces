using System;
using System.Collections.Generic;
using System.Text;

namespace TestInterface3
{
    interface IRadioPlayer
    {
        void onOff(bool on);

        void retune(double frequency);

        void setVolume(int loudness);

        void changeChannel();
    }
}
