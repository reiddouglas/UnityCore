using Assets.Scripts.Core.Events.Base;
using UnityEngine;

namespace Assets.Scripts.Systems.SceneSystem.Events
{
    [CreateAssetMenu(
    fileName = "SceneDataEventChannel",
    menuName = "Events/SceneData Event Channel")]
    public class SceneDataEventChannel : BaseEventChannel<SceneData>
    {
    }
}
