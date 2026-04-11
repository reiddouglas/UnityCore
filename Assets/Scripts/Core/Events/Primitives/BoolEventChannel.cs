using Assets.Scripts.Core.Events.Base;
using UnityEngine;

[CreateAssetMenu(
    fileName = "BoolEventChannel",
    menuName = "Events/Bool Event Channel"
)]
public class BoolEventChannel : BaseEventChannel<bool>
{
}