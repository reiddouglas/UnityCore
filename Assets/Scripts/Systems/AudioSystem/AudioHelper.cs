using System;

namespace Assets.Scripts.Systems.AudioSystem
{
    /// <summary>
    /// Helper class for audio-related functions.
    /// </summary>
    public class AudioHelper
    {
        public AudioHelper() { }

        /// <summary>
        /// Converts audio in decibals to a linear value between 0 and 1.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public float DecibalToLinear(float value)
        {
            return MathF.Log10(value) * 20;
        }

        /// <summary>
        /// Converts audio from a linear value between 0 and 1 to decibals.
        /// </summary>
        /// <param name="dB"></param>
        /// <returns></returns>
        public float LinearToDecibal(float dB)
        {
            return MathF.Pow(10f, dB / 20f);
        }
    }
}
