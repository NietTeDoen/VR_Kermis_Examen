using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveableEntity : MonoBehaviour
{
    [SerializeField] private string id;
    public string Id => id;

    [ContextMenu("Generate Id")]
    private void GenerateId()
    {
        id = Guid.NewGuid().ToString();
    }

    //find all Isavable components on gameobject
    public object SaveState()
    {
        var state = new Dictionary<string, object>();
        foreach(var saveable in GetComponents<Isaveable>())
        {
            state[saveable.GetType().ToString()] = saveable.SaveState();
        }
        return state;
    }

    public void Loadstate(object state)
    {
        var stateDictionary = (Dictionary<string, object>)state;
        foreach (var saveable in GetComponents<Isaveable>())
        {
            string typeName = saveable.GetType().ToString();
            if( stateDictionary.TryGetValue(typeName, out object savedState))
            {
                saveable.LoadState(savedState);
            }
        }
    }
}
