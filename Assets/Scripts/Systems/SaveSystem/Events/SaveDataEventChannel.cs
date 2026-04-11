using Assets.Scripts.Core.Events.Base;
using UnityEngine;

namespace Assets.Scripts.Systems.SaveSystem
{
    [CreateAssetMenu(
    fileName = "SaveDataEventChannel",
    menuName = "Events/SaveData Event Channel")]
    public class SaveDataEventChannel : BaseEventChannel<SaveData>
    {
    }

    class SaveDataEventListener : BaseEventListener<SaveData>
    {
    }
}
