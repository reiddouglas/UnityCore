using Assets.Scripts.Core.Events.Base;
using UnityEngine;

namespace Assets.Scripts.Systems.SceneSystem.Events
{
    [CreateAssetMenu(
    fileName = "TransitionPhaseEventChannel",
    menuName = "Events/TransitionPhase Event Channel")]
    public class TransitionPhaseEventChannel : BaseEventChannel<TransitionPhase>
    {
    }
}