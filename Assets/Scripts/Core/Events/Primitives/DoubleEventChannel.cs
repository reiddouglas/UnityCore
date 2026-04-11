using Assets.Scripts.Core.Events.Base;
using UnityEngine;

[CreateAssetMenu(
    fileName = "DoubleEventChannel",
    menuName = "Events/Double Event Channel"
)]
public class DoubleEventChannel : BaseEventChannel<double>
{
}