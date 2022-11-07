using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerprefsLoader : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
        switch (PlayerPrefs.GetInt("001"))
        {
            case 1:
                PurchaseManager.BMagazin1 = true;
                break;
            case 0:
                PurchaseManager.BMagazin1 = false;
                break;
        }
        switch (PlayerPrefs.GetInt("002"))
        {
            case 1:
                PurchaseManager.BMagazin2 = true;
                break;
            case 0:
                PurchaseManager.BMagazin2 = false;
                break;
        }
        switch (PlayerPrefs.GetInt("003"))
        {
            case 1:
                PurchaseManager.BMagazin3 = true;
                break;
            case 0:
                PurchaseManager.BMagazin3 = false;
                break;
        }
        switch (PlayerPrefs.GetInt("004"))
        {
            case 1:
                PurchaseManager.BMagazin4 = true;
                break;
            case 0:
                PurchaseManager.BMagazin4 = false;
                break;
        }
        switch (PlayerPrefs.GetInt("005"))
        {
            case 1:
                PurchaseManager.BMagazin5 = true;
                break;
            case 0:
                PurchaseManager.BMagazin5 = false;
                break;
        }
        switch (PlayerPrefs.GetInt("006"))
        {
            case 1:
                PurchaseManager.BMagazin6 = true;
                break;
            case 0:
                PurchaseManager.BMagazin6 = false;
                break;
        }
        switch (PlayerPrefs.GetInt("007"))
        {
            case 1:
                PurchaseManager.BMagazin7 = true;
                break;
            case 0:
                PurchaseManager.BMagazin7 = false;
                break;
        }
        switch (PlayerPrefs.GetInt("008"))
        {
            case 1:
                PurchaseManager.BMagazin8 = true;
                break;
            case 0:
                PurchaseManager.BMagazin8 = false;
                break;
        }
        switch (PlayerPrefs.GetInt("009"))
        {
            case 1:
                PurchaseManager.BMagazin9 = true;
                break;
            case 0:
                PurchaseManager.BMagazin9 = false;
                break;
        }
        switch (PlayerPrefs.GetInt("010"))
        {
            case 1:
                PurchaseManager.BMagazin10 = true;
                break;
            case 0:
                PurchaseManager.BMagazin10 = false;
                break;
        }

        score_system.score = PlayerPrefs.GetInt("Score");
    }

    public void PlayerPrefSaver()
    {
        switch(PurchaseManager.BMagazin1)
        {
            case true:
                PlayerPrefs.SetInt("001", 1);
                break;
            case false:
                PlayerPrefs.SetInt("001", 0);
                break;
        }
        switch (PurchaseManager.BMagazin2)
        {
            case true:
                PlayerPrefs.SetInt("002", 1);
                break;
            case false:
                PlayerPrefs.SetInt("002", 0);
                break;
        }
        switch (PurchaseManager.BMagazin3)
        {
            case true:
                PlayerPrefs.SetInt("003", 1);
                break;
            case false:
                PlayerPrefs.SetInt("003", 0);
                break;
        }
        switch (PurchaseManager.BMagazin4)
        {
            case true:
                PlayerPrefs.SetInt("004", 1);
                break;
            case false:
                PlayerPrefs.SetInt("004", 0);
                break;
        }
        switch (PurchaseManager.BMagazin5)
        {
            case true:
                PlayerPrefs.SetInt("005", 1);
                break;
            case false:
                PlayerPrefs.SetInt("005", 0);
                break;
        }
        switch (PurchaseManager.BMagazin6)
        {
            case true:
                PlayerPrefs.SetInt("006", 1);
                break;
            case false:
                PlayerPrefs.SetInt("006", 0);
                break;
        }
        switch (PurchaseManager.BMagazin7)
        {
            case true:
                PlayerPrefs.SetInt("007", 1);
                break;
            case false:
                PlayerPrefs.SetInt("007", 0);
                break;
        }
        switch (PurchaseManager.BMagazin8)
        {
            case true:
                PlayerPrefs.SetInt("008", 1);
                break;
            case false:
                PlayerPrefs.SetInt("008", 0);
                break;
        }
        switch (PurchaseManager.BMagazin9)
        {
            case true:
                PlayerPrefs.SetInt("009", 1);
                break;
            case false:
                PlayerPrefs.SetInt("009", 0);
                break;
        }
        switch (PurchaseManager.BMagazin10)
        {
            case true:
                PlayerPrefs.SetInt("010", 1);
                break;
            case false:
                PlayerPrefs.SetInt("010", 0);
                break;
        }

        print(" your score is: " + score_system.score);
        PlayerPrefs.SetInt("Score", (int)score_system.score);
        PlayerPrefs.Save();
        print(PlayerPrefs.GetInt("Score"));
    }
}
