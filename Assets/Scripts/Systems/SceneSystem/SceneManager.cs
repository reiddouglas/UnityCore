using Assets.Scripts.Core.Events.Primitives;
using Assets.Scripts.Core.Managers.Base;
using Assets.Scripts.Core.Managers.Interfaces;
using Assets.Scripts.Systems.SceneSystem.Events;
using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Systems.SceneSystem
{
    public class SceneManager : BaseManager<SceneManager>, IManager
    {
        private bool isLoading;
        private bool transitionOutComplete;
        private bool transitionInComplete;
        private GameObject transitionInstance = null;

        [SerializeField]
        private TransitionPhaseEventChannel transitionStartedEvent;
        [SerializeField]
        private FloatEventChannel loadingProgressEvent;

        public void LoadScene(SceneData sceneData)
        {
            if (isLoading) return;

            StartCoroutine(LoadSceneRoutine(sceneData));
        }

        public void onTransitionComplete(TransitionPhase phase)
        {
            _logger.Log($"Transition complete: {phase}");
            if (phase == TransitionPhase.Out)
            {
                transitionOutComplete = true;
            }
            else if (phase == TransitionPhase.In)
            {
                transitionInComplete = true;
            }
        }

        private IEnumerator LoadSceneRoutine(SceneData sceneData)
        {
            isLoading = true;
            transitionOutComplete = false;

            string sceneName = sceneData.sceneName;

            if (UnityEngine.SceneManagement.SceneManager.GetActiveScene().name == sceneName)
            {
                _logger.Log($"Change to identical scene {sceneName} ignored");
                isLoading = false;
                yield break;
            }

            if (sceneData.transitionPrefab != null)
            {
                transitionInstance = Instantiate(sceneData.transitionPrefab);
                DontDestroyOnLoad(transitionInstance);
            }

            transitionStartedEvent.Raise(TransitionPhase.Out);

            yield return new WaitUntil(() => transitionOutComplete);

            var asyncLoad = UnityEngine.SceneManagement.SceneManager.LoadSceneAsync(sceneName);
            asyncLoad.allowSceneActivation = false;

            while (asyncLoad.progress < 0.9f)
            {
                float progress = asyncLoad.progress / 0.9f;
                loadingProgressEvent.Raise(progress);
                yield return null;
            }

            yield return new WaitForSeconds(0.1f);

            asyncLoad.allowSceneActivation = true;

            while (!asyncLoad.isDone)
            {
                yield return null;
            }

            transitionInComplete = false;

            transitionStartedEvent.Raise(TransitionPhase.In);

            yield return new WaitUntil(() => transitionInComplete);

            if (transitionInstance != null)
            {
                Destroy(transitionInstance);
            }

            isLoading = false;
        }
    }
}
