using UnityEngine;

[CreateAssetMenu(menuName = "Debug/Logging Group")]
public class LoggingGroup : ScriptableObject
{
    [Header("Enable logging for this group")]
    public bool isEnabled = false;
}
