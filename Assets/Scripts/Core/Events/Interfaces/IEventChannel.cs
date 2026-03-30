namespace Assets.Scripts.Core.Events.Interfaces
{
    public interface IEventChannel<T>
    {
        void Raise(T value);
        void RegisterListener(IEventListener<T> listener);
        void UnregisterListener(IEventListener<T> listener);

    }
}
