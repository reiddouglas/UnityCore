using Assets.Scripts.Core.Events.Base;
using UnityEngine;

namespace Assets.Scripts.Systems.AudioSystem.Events
{
    [CreateAssetMenu(
    fileName = "AudioDataEventChannel",
    menuName = "Events/AudioData Event Channel")]
    public class AudioDataEventChannel : BaseEventChannel<AudioData>
    {
    }
}
