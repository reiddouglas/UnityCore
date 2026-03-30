using Assets.Scripts.Core.Managers.Interfaces;
using UnityEngine;

namespace Assets.Scripts.Core.Managers.Base
{
    public abstract class BaseManager<T> : MonoBehaviour where T : MonoBehaviour, IManager
    {
        public static T Instance { get; private set; }

        [SerializeField]
        protected Logger _logger;

        protected bool isInitialized = false;
        protected bool isActive = true;

        protected virtual void Awake()
        {
            if (Instance != null && Instance != this)
            {
                Destroy(gameObject); // avoid duplicates
                return;
            }
            Instance = this as T;
            DontDestroyOnLoad(gameObject);
            Initialize();
        }

        protected virtual void Initialize()
        {
            isInitialized = true;
            _logger.Log("Initialized", this);
        }

        public virtual void EnableManager()
        {
            isActive = true;
            _logger.Log("Enabled", this);
        }

        public virtual void DisableManager()
        {
            isActive = false;
            _logger.Log("Disabled", this);
        }
    }
}
