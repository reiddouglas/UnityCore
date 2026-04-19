using UnityEngine;

namespace Assets.Scripts.Systems.SceneSystem
{
    [CreateAssetMenu(menuName = "Scenes/Scene Data")]
    public class SceneData : ScriptableObject
    {
        public string sceneName;

        [Header("Transitions")]
        [SerializeField] public GameObject transitionPrefab;
    }
}
