namespace Assets.Scripts.Core.Events.Interfaces
{
    public interface IEventListener<T>
    {
        /// <summary>
        /// The listeners response to an event being raised.
        /// </summary>
        /// <param name="value"></param>
        public void OnEventRaised(T value);
    }
}
