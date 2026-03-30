using Assets.Scripts.Core.Managers.Base;
using Assets.Scripts.Core.Managers.Interfaces;
using System.IO;
using UnityEngine;
using static System.Net.Mime.MediaTypeNames;

namespace Assets.Scripts.Systems.SaveSystem
{
    /// <summary>
    /// In charge of saving and loading a <see cref="SaveData"/> object to file.
    /// </summary>
    public class SaveManager : BaseManager<SaveManager>, IManager
    {
        [SerializeField]
        SaveDataEventChannel saveChannel;
        [SerializeField]
        SaveDataEventChannel loadChannel;

        private readonly string saveFile = "save_";

        private string GetSavePath(int slot)
        {
            return Path.Combine(Application.persistentDataPath, $"{saveFile}{slot}.json");
        }

        /// <summary>
        /// Saves data to a file slot.
        /// </summary>
        /// <param name="slot"></param>
        public void SaveGame(int slot)
        {
            SaveData data = new();

            saveChannel.Raise(data);

            string json = JsonUtility.ToJson(data, true);

            File.WriteAllText(GetSavePath(slot), json);

            _logger.Log($"Game saved to {savePath}");
        }

        /// <summary>
        /// Loads data from a file slot.
        /// </summary>
        /// <param name="slot"></param>
        public void LoadGame(int slot)
        {
            if (!File.Exists(savePath))
            {
                _logger.LogWarning("No save file found!");
                return;
            }

            string json = File.ReadAllText(GetSavePath(slot));

            SaveData data = JsonUtility.FromJson<SaveData>(json);

            loadChannel.Raise(data);
        }
    }
}
