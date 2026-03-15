using Assets.Scripts.EventChannels;
using UnityEngine;
using UnityEngine.Events;

public abstract class BaseEventListener<T> : MonoBehaviour, IEventListener<T>
{
    public BaseEventChannel<T> eventChannel;
    public UnityEvent<T> response;

    [SerializeField]
    private Logger _logger;

    private void OnEnable()
    {
        if (eventChannel != null)
            eventChannel.RegisterListener(this);
        _logger.LogWarning($"{name} has no eventChannel");
    }

    private void OnDisable()
    {
        if (eventChannel != null)
            eventChannel.UnregisterListener(this);
    }

    public void OnEventRaised(T value)
    {
        _logger.Log($"{name} received event with value {value}");
        Respond(value);
    }

    protected void Respond(T value)
    {
        response?.Invoke(value);
    }
}