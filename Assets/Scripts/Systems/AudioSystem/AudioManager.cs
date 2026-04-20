using Assets.Scripts.Core.Managers.Base;
using Assets.Scripts.Core.Managers.Interfaces;
using UnityEngine;
using UnityEngine.Audio;

namespace Assets.Scripts.Systems.AudioSystem
{
    /// <summary>
    /// A singleton responsible for managing audio.
    /// </summary>
    public class AudioManager : BaseManager<AudioManager>, IManager
    {
        [SerializeField]
        private AudioSource audioSourcePrefab;
        [SerializeField]
        private AudioMixer audioMixer;

        private AudioHelper audioHelper = new AudioHelper();

        /// <summary>
        /// Plays an audio clip.
        /// </summary>
        /// <param name="audioData"></param>
        public void PlayAudio(AudioData audioData)
        {
            if (audioData.audioCue.clip == null)
            {
                _logger.LogWarning("Tried to play null audio");
                return;
            }

            AudioSource source = Instantiate(audioSourcePrefab, transform);

            source.clip = audioData.audioCue.clip;
            source.outputAudioMixerGroup = audioData.audioCue.channel.mixerGroup;
            source.volume = audioData.audioCue.volume;

            switch (audioData.audioCue.spatialMode)
            {
                case AudioSpatialMode.None:
                    source.spatialBlend = 0f;
                    break;

                case AudioSpatialMode.World2D:
                    source.spatialBlend = 1f;

                    if (audioData.transform != null)
                    {
                        Vector3 pos = audioData.transform.position;
                        source.transform.position = new Vector3(pos.x, pos.y, 0f);
                    }
                    else
                    {
                        _logger.LogWarning("2D Spatial audio playing with no set transform");
                    }

                    source.minDistance = audioData.audioCue.minDistance;
                    source.maxDistance = audioData.audioCue.maxDistance;
                    break;

                case AudioSpatialMode.World3D:
                    source.spatialBlend = 1f;

                    if (audioData.transform != null)
                    {
                        source.transform.position = audioData.transform.position;
                    }
                    else
                    {
                        _logger.LogWarning("3D Spatial audio playing with no set transform");
                    }

                    source.minDistance = audioData.audioCue.minDistance;
                    source.maxDistance = audioData.audioCue.maxDistance;
                    break;
            }

            source.Play();

            Destroy(source.gameObject, source.clip.length);
        }

        /// <summary>
        /// Sets the volume of an audio mixer.
        /// </summary>
        /// <param name="volumeData"></param>
        public void SetVolume(VolumeData volumeData)
        {
            float dB = audioHelper.LinearToDecibal(volumeData.volume);
            audioMixer.SetFloat(volumeData.channel.parameterName, dB);
        }

        /// <summary>
        /// Gets the current volume of an audio mixer in decibals
        /// </summary>
        /// <param name="channel"></param>
        /// <returns></returns>
        public VolumeData GetVolume(AudioChannel channel)
        {
            audioMixer.GetFloat(channel.parameterName, out float Db);
            return new VolumeData(channel, audioHelper.DecibalToLinear(Db));
        }
    }
}
