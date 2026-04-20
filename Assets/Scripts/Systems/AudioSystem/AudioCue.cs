using UnityEngine;

namespace Assets.Scripts.Systems.AudioSystem
{
    [CreateAssetMenu(menuName = "Audio/Audio Cue")]
    public class AudioCue : ScriptableObject
    {
        public AudioClip clip;
        public AudioChannel channel;

        [Range(0f, 1f)]
        public float volume = 1f;

        public AudioSpatialMode spatialMode;

        public float minDistance = 1f;
        public float maxDistance = 15f;
    }
}
