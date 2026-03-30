namespace Assets.Scripts.Core.Events.Interfaces
{
    public interface IEventListener<T>
    {
        public void OnEventRaised(T value);
    }
}
