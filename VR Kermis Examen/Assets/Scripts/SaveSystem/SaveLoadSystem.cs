using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class SaveLoadSystem : MonoBehaviour
{
    public string SavePath => $"{Application.persistentDataPath}/save.txt";

    [ContextMenu("Save")]
    public void save()
    {
        var state = Loadfile();
        SaveState(state);
        saveFile(state);
    }

    [ContextMenu("Load")]
    public void Load()
    {
        var state = Loadfile();
        LoadState(state);
    }


    public void saveFile(object state)
    {
        using (var stream = File.Open(SavePath, FileMode.Create))
        {
            var formatter = new BinaryFormatter();
            formatter.Serialize(stream, state);
        }
    }

    Dictionary<string, object> Loadfile()
    {
        if (!File.Exists(SavePath))
        {
            Debug.Log("No save file found");
            return new Dictionary<string, object>();
        }

        using (FileStream stream = File.Open(SavePath, FileMode.Open))
        {
            var formatter = new BinaryFormatter();
            return (Dictionary<string, object>)formatter.Deserialize(stream);
        }
    }

    public void ClearFile()
    {
        if (File.Exists(SavePath)){
            File.Delete(SavePath);
        }
    }

    void SaveState(Dictionary<string, object> state)
    {
        foreach(var saveable in FindObjectsOfType<SaveableEntity>())
        {
            state[saveable.Id] = saveable.SaveState();
        }
    }
    void LoadState(Dictionary<string, object> state)
    {
        foreach (var saveable in FindObjectsOfType<SaveableEntity>())
        {
            if(state.TryGetValue(saveable.Id, out object savedState))
            {
                saveable.Loadstate(savedState);
            }
        }
    }
}
