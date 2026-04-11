using Assets.Scripts.Core.Managers.Base;
using Assets.Scripts.Core.Managers.Interfaces;
using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Systems.SceneSystem
{
    public class SceneManager : BaseManager<SceneManager>, IManager
    {
        private bool isLoading;

        public void LoadScene(SceneData sceneData)
        {
            if (isLoading) return;

            StartCoroutine(LoadSceneRoutine(sceneData));
        }

        private IEnumerator LoadSceneRoutine(SceneData sceneData)
        {
            isLoading = true;

            string sceneName = sceneData.sceneName;

            if (UnityEngine.SceneManagement.SceneManager.GetActiveScene().name == sceneName)
            {
                isLoading = false;
                yield break;
            }

            var asyncLoad = UnityEngine.SceneManagement.SceneManager.LoadSceneAsync(sceneName);

            while (asyncLoad.progress < 0.9f)
            {
                yield return null;
            }

            yield return new WaitForSeconds(0.1f);

            asyncLoad.allowSceneActivation = true;

            while (!asyncLoad.isDone)
            {
                yield return null;
            }

            isLoading = false;
        }
    }
}
