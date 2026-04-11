using Assets.Scripts.Core.Events.Base;
using UnityEngine;

[CreateAssetMenu(
    fileName = "FloatEventChannel",
    menuName = "Events/Float Event Channel"
)]
public class BoolEventChannel : BaseEventChannel<float>
{
}