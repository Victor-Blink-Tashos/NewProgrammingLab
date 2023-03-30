using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System.IO;

namespace SaveLoadSystem
{
    public static class DataManager
    {
        public static Data CurrentSaveData = new Data();

        public const string SaveDirectory = "/Info/";

        public const string FileName = "SaveGame.sav";

        public static readonly string keyWord = "E10";
       
        public static bool SaveGame()
        {
            var d = Application.persistentDataPath + SaveDirectory;

            if (!Directory.Exists(d))
            {
                Directory.CreateDirectory(d);
            }

            string json = JsonUtility.ToJson(CurrentSaveData, true);
            var encryptedJson = Encrypter(json);
            File.WriteAllText(d + FileName, encryptedJson);

            GUIUtility.systemCopyBuffer = d;

            return true;
        }

        public static void LoadGame()
        {
            string fullPath = Application.persistentDataPath + SaveDirectory + FileName;
            Data tempData = new Data();

            if (File.Exists(fullPath))
            {
                var json = File.ReadAllText(fullPath);
                tempData = JsonUtility.FromJson<Data>(Encrypter(json));
            }
            else
            {
                Debug.LogError("Save file does not exist");
            }

            CurrentSaveData = tempData;
        }

        private static string Encrypter(string data)
        {
            string result = "";

            for (int i = 0; i < data.Length; i++)
            {
                result += (char)(data[i] ^ keyWord[i % keyWord.Length]);
            }

            return result;
        }
    }

}
