using Assets.Scripts.Core.Events.Base;
using UnityEngine;

namespace Assets.Scripts.Core.Events.Primitives
{
    [CreateAssetMenu(
    fileName = "BoolEventChannel",
    menuName = "Events/Bool Event Channel")]
    public class BoolEventChannel : BaseEventChannel<bool>
    {
    }
}
