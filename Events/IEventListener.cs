namespace Assets.Scripts.EventChannels
{
    public interface IEventListener<T>
    {
        /// <summary>
        /// The event listener's response to <see cref="IEventChannel{T}.Raise(T)"/>
        /// </summary>
        /// <param name="value"></param>
        void OnEventRaised(T value);
    }
}
