namespace Assets.Scripts.EventChannels
{
    public interface IEventChannel<T>
    {
        /// <summary>
        /// Triggers the <see cref="IEventListener{T}.OnEventRaised(T)"/> of all registered events.
        /// </summary>
        /// <param name="value"></param>
        void Raise(T value);

        /// <summary>
        /// Registers a listener to the event channel. If the listener is already registered, does nothing.
        /// </summary>
        /// <param name="listener"></param>
        void RegisterListener(IEventListener<T> listener);

        /// <summary>
        /// Unregisters a listener from the event channel. If the listener is not registered, does nothing.
        /// </summary>
        /// <param name="listener"></param>
        void UnregisterListener(IEventListener<T> listener);
    }
}
