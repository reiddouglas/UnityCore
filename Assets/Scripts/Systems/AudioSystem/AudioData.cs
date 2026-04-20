using UnityEngine;

namespace Assets.Scripts.Systems.AudioSystem
{
    /// <summary>
    /// Contains all data needed by the <see cref="AudioManager"/> to play an audio clip
    /// </summary>
    public class AudioData
    {
        public AudioCue audioCue;
        public Transform transform;

        // Constructor for spatial audio.
        public AudioData(AudioCue audioCue, Transform transform)
        {
            this.audioCue = audioCue;
            this.transform = transform;
        }

        // Constructor for non-spatial audio.
        public AudioData(AudioCue audioCue)
        {
            this.audioCue = audioCue;
        }
    }
}
