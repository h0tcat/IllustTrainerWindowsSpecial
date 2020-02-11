using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nori.soft.util
{
    class SoundHelper : System.Media.SoundPlayer
    {
        public SoundHelper(string bgmFilePath) : base(bgmFilePath)
        {

        }

        public void Play(bool playLoop)
        {
            if (playLoop)
                base.PlayLooping();
            else
                base.Play();
        }

    }
}
