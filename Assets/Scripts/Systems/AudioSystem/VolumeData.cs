namespace Assets.Scripts.Systems.AudioSystem
{
    /// <summary>
    /// Contains all data needed by <see cref="AudioManager"/> to change the volume of an audio mixer.
    /// </summary>
    public class VolumeData
    {
        public AudioChannel channel;
        public float volume;
        public VolumeData(AudioChannel channel, float volume)
        {
            this.channel = channel;
            this.volume = volume;
        }
    }
}
