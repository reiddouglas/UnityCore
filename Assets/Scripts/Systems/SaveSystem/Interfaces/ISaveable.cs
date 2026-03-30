namespace Assets.Scripts.Systems.SaveSystem.Interfaces
{
    /// <summary>
    /// An interface for classes that store their data in saves.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface ISaveable<T> where T : ISaveData
    {
        /// <summary>
        /// Convert class fields into a <see cref="ISaveData"/> DTO.
        /// </summary>
        /// <remarks>
        /// If some fields are <see cref="ISaveable{T}"/> fields, use this function to convert them recursively.
        /// </remarks>
        /// <returns>An <see cref="ISaveData"/> DTO with the relevant data to be saved.</returns>
        T GetSaveData();

        /// <summary>
        /// Populates the caller's fields with the data in the passed <see cref="ISaveData"/> DTO.
        /// </summary>
        /// <remarks>
        /// If some fields are <see cref="ISaveable{T}"/>, use this function to populate their fields recursively.
        /// </remarks>
        /// <param name="data"></param>
        void LoadSaveData(T data);
    }
}
