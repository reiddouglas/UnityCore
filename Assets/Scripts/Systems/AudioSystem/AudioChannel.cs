using UnityEngine;
using UnityEngine.Audio;

namespace Assets.Scripts.Systems.AudioSystem
{
    [CreateAssetMenu(menuName = "Audio/Audio Channel")]
    public class AudioChannel : ScriptableObject
    {
        public string parameterName;
        public AudioMixerGroup mixerGroup;
    }
}
