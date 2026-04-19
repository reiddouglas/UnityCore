using Assets.Scripts.Systems.SceneSystem.Events;
using UnityEngine;

namespace Assets.Scripts.Systems.SceneSystem
{
    public class SceneTransitionController : MonoBehaviour
    {
        [SerializeField]
        private Animator animator;

        [SerializeField]
        private TransitionPhaseEventChannel transitionFinishedEvent;

        private bool isPlaying = false;
        private TransitionPhase currentTransition;

        private readonly string inTrigger = "In";
        private readonly string outTrigger = "Out";

        private Logger _logger = new Logger();

        private void Awake()
        {
            if (animator == null)
                animator = GetComponentInChildren<Animator>();
        }

        public void PlayTransition(TransitionPhase transitionPhase)
        {
            if (isPlaying) return;

            isPlaying = true;
            currentTransition = transitionPhase;

            _logger.Log($"Starting transition: {transitionPhase}");
            switch (transitionPhase)
            {
                case TransitionPhase.In:
                    animator.ResetTrigger(inTrigger);
                    animator.SetTrigger(outTrigger);
                    break;
                case TransitionPhase.Out:
                    animator.ResetTrigger(outTrigger);
                    animator.SetTrigger(inTrigger);
                    break;
                default:
                    _logger.LogError("Entered default case when playing transition");
                    break;
            }
        }

        public void OnTransitionComplete()
        {
            isPlaying = false;
            transitionFinishedEvent.Raise(currentTransition);
        }
    }
}
