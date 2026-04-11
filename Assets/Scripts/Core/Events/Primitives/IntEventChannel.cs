using Assets.Scripts.Core.Events.Base;
using UnityEngine;

namespace Assets.Scripts.Core.Events.Primitives
{
    [CreateAssetMenu(
    fileName = "IntEventChannel",
    menuName = "Events/Int Event Channel")]
    public class IntEventChannel : BaseEventChannel<int>
    {
    }
}
