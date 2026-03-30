using Assets.Scripts.Core.Events.Interfaces;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Core.Events.Base
{
    public abstract class BaseEventChannel<T> : ScriptableObject, IEventChannel<T>
    {
        private readonly List<IEventListener<T>> runtimeListeners = new List<IEventListener<T>>();

        [SerializeField]
        private Logger _logger;

        public void Raise(T value)
        {
            _logger.Log($"{name} Event Raised: {value}");
            for (int i = runtimeListeners.Count - 1; i >= 0; i--)
            {
                runtimeListeners[i].OnEventRaised(value);
            }
        }

        public void RegisterListener(IEventListener<T> listener)
        {
            _logger.Log($"{name} Registered Listener: {listener}");
            if (!runtimeListeners.Contains(listener))
                runtimeListeners.Add(listener);
        }

        public void UnregisterListener(IEventListener<T> listener)
        {
            _logger.Log($"{name} Unregistered Listener: {listener}");
            if (runtimeListeners.Contains(listener))
                runtimeListeners.Remove(listener);
        }
    }
}
