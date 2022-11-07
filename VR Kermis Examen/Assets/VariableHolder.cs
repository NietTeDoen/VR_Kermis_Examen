using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class VariableHolder : MonoBehaviour, Isaveable
{
    public object SaveState()
    {
        return new SaveData()
        {
            Datascore = score_system.score,
            DataMagazin1 = PurchaseManager.BMagazin1,
            DataMagazin2 = PurchaseManager.BMagazin2,
            DataMagazin3 = PurchaseManager.BMagazin3,
            DataMagazin4 = PurchaseManager.BMagazin4,
            DataMagazin5 = PurchaseManager.BMagazin5,
            DataMagazin6 = PurchaseManager.BMagazin6,
            DataMagazin7 = PurchaseManager.BMagazin7,
            DataMagazin8 = PurchaseManager.BMagazin8,
            DataMagazin9 = PurchaseManager.BMagazin9,
            DataMagazin10 = PurchaseManager.BMagazin10
        };
    }

    public void LoadState(object state)
    {
        var saveData = (SaveData)state;
        score_system.score = (int)saveData.Datascore;
        PurchaseManager.BMagazin1 = (bool)saveData.DataMagazin1;
        PurchaseManager.BMagazin2 = (bool)saveData.DataMagazin2;
        PurchaseManager.BMagazin3 = (bool)saveData.DataMagazin3;
        PurchaseManager.BMagazin4 = (bool)saveData.DataMagazin4;
        PurchaseManager.BMagazin5 = (bool)saveData.DataMagazin5;
        PurchaseManager.BMagazin6 = (bool)saveData.DataMagazin6;
        PurchaseManager.BMagazin7 = (bool)saveData.DataMagazin7;
        PurchaseManager.BMagazin8 = (bool)saveData.DataMagazin8;
        PurchaseManager.BMagazin9 = (bool)saveData.DataMagazin9;
        PurchaseManager.BMagazin10 = (bool)saveData.DataMagazin10;
    }

    [Serializable]
    public struct SaveData
    {
        public float Datascore;
        public bool DataMagazin1;
        public bool DataMagazin2;
        public bool DataMagazin3;
        public bool DataMagazin4;
        public bool DataMagazin5;
        public bool DataMagazin6;
        public bool DataMagazin7;
        public bool DataMagazin8;
        public bool DataMagazin9;
        public bool DataMagazin10;
        public float DataVolume;
    }
}
