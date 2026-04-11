using Assets.Scripts.Core.Events.Base;
using UnityEngine;

namespace Assets.Scripts.Core.Events.Primitives
{
    [CreateAssetMenu(
    fileName = "FloatEventChannel",
    menuName = "Events/Float Event Channel")]
    public class BoolEventChannel : BaseEventChannel<float>
    {
    }
}