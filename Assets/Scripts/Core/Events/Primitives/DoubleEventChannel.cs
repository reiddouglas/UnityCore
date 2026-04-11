using Assets.Scripts.Core.Events.Base;
using UnityEngine;

namespace Assets.Scripts.Core.Events.Primitives
{
    [CreateAssetMenu(
    fileName = "DoubleEventChannel",
    menuName = "Events/Double Event Channel")]
    public class DoubleEventChannel : BaseEventChannel<double>
    {
    }
}
