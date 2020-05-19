using System;
using System.Media;

namespace OOExample
{
    class Horn
    {
        private SoundPlayer soundPlayer; 
        /// <summary>
        /// Constructor for a horn with a custom sound
        /// </summary>
        /// <param name="s">A sound as defined in the Sound enum</param>
        public Horn(Sound s)
        {
            string soundToPlay = SoundPicker(s);
            if(soundToPlay != null)
            {
                soundPlayer = new SoundPlayer();
                soundPlayer.SoundLocation = soundToPlay;
            }
            
        }
        /// <summary>
        /// Makes the horn play its sound
        /// </summary>
        /// <returns>A string telling if the sound has been played or not</returns>
        public string MakeSound()
        {
            if (soundPlayer != null)
                soundPlayer.Play();
            else
                return "This horn has no sound!";
            return "Sound played";
        }
        /// <summary>
        /// Internal soundpicker that translates the chosen enum to an actual sound
        /// </summary>
        /// <param name="s">The enum containing a sound</param>
        /// <returns>A string with a path to the sound OR null if none is found</returns>
        private string SoundPicker(Sound s)
        {
            switch (s)
            {
                case Sound.doot:
                    return Environment.CurrentDirectory + @"\\Assets\\doot.wav";
                case Sound.train:
                    return Environment.CurrentDirectory + @"\\Assets\\train.wav";
                default:
                    return null;
            }
        }

    }
}
