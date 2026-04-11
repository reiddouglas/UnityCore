using Assets.Scripts.Core.Events.Base;
using UnityEngine;

[CreateAssetMenu(
    fileName = "StringEventChannel",
    menuName = "Events/String Event Channel"
)]
public class StringEventChannel : BaseEventChannel<string>
{
}