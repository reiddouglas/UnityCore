namespace Assets.Scripts.Systems.SaveSystem.Interfaces
{
    /// <summary>
    /// An interface for classes that save information to a top-level field in a <see cref="ISaveData"/> DTO being saved by a <see cref="SaveManager"/>.
    /// </summary>
    public interface ISaveParticipant<T> where T : ISaveData
    {
        /// <summary>
        /// Assigns data to a field in the passed <see cref="ISaveData"/>.
        /// </summary>
        /// <param name="data"></param>
        void AddToSave(T data);

        /// <summary>
        /// Loads data from the appropriate field in the passed <see cref="ISaveData"/>
        /// </summary>
        /// <param name="data"></param>
        void LoadFromSave(T data);
    }
}
