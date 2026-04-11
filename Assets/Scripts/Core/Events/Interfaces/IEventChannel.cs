namespace Assets.Scripts.Core.Events.Interfaces
{
    public interface IEventChannel<T>
    {
        /// <summary>
        /// Broadcasts the event to all registered listeners.
        /// </summary>
        /// <param name="value"></param>
        void Raise(T value);

        /// <summary>
        /// Registers an <see cref="IEventListener{T}"/> to the channel. If the listener is already registered, does nothing.
        /// </summary>
        /// <param name="listener"></param>
        void RegisterListener(IEventListener<T> listener);

        /// <summary>
        /// Unregisters an <see cref="IEventListener{T}"/> to the channel. If the listener is not registered, does nothing.
        /// </summary>
        /// <param name="listener"></param>
        void UnregisterListener(IEventListener<T> listener);

    }
}
