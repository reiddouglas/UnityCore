using Assets.Scripts.Core.Events.Base;
using UnityEngine;

namespace Assets.Scripts.Core.Events.Primitives
{
    [CreateAssetMenu(
        fileName = "StringEventChannel",
        menuName = "Events/String Event Channel")]
    public class StringEventChannel : BaseEventChannel<string>
    {
    }
}
