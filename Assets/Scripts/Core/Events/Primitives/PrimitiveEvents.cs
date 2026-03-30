using Assets.Scripts.Core.Events.Base;
using UnityEngine;


namespace Assets.Scripts.Core.Events.Primitives
{
    [CreateAssetMenu(
    fileName = "BoolEventChannel",
    menuName = "Events/Primitives/Bool Event Channel")]
    public class BoolEventChannel : BaseEventChannel<bool>
    {
    }

    class BoolEventListener : BaseEventListener<bool>
    {
    }

    [CreateAssetMenu(
    fileName = "DoubleEventChannel",
    menuName = "Events/Primitives/Double Event Channel")]
    public class DoubleEventChannel : BaseEventChannel<double>
    {
    }

    class DoubleEventListener : BaseEventListener<double>
    {
    }

    [CreateAssetMenu(
    fileName = "FloatEventChannel",
    menuName = "Events/Primitives/Float Event Channel")]
    public class FloatEventChannel : BaseEventChannel<float>
    {
    }

    class FloatEventListener : BaseEventListener<float>
    {
    }

    [CreateAssetMenu(
    fileName = "IntEventChannel",
    menuName = "Events/Primitives/Int Event Channel")]
    public class IntEventChannel : BaseEventChannel<int>
    {
    }

    class IntEventListener : BaseEventListener<int>
    {
    }

    [CreateAssetMenu(
    fileName = "StringEventChannel",
    menuName = "Events/Primitives/String Event Channel")]
    public class StringEventChannel : BaseEventChannel<string>
    {
    }

    class StringEventListener : BaseEventListener<string>
    {
    }
}