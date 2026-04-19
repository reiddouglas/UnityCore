using System.Collections;

namespace Assets.Scripts.Systems.SceneSystem.Interfaces
{
    public interface ISceneTransition
    {
        IEnumerator PlayOut();
        IEnumerator PlayIn();
    }
}
