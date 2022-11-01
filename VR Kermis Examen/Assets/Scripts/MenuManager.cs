using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{

    public int DataNumber;
    public Text ScoreTXT;
    public static Button[] SoldItems;
    // Start is called before the first frame update
    void Start()
    {
        ScoreTXT.text = score_system.score.ToString();
        score_system.score = 145;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SwitchToGame()
    {
        SceneManager.LoadScene(1);
    }

    public void quit()
    {
        Application.Quit();
    }

    public void PurchaseItem(int ItemID)
    {
        Button ItemPurchase = GameObject.Find("Item" + ItemID).GetComponent<Button>();
        if(score_system.score >= 50)
        {
            ItemPurchase.interactable = false;
            score_system.score -= 50;
            ScoreTXT.text = score_system.score.ToString();
            PlayerPrefs.SetInt(ItemID.ToString(), 1); //Int 1 means having the item 0 means you don't have the item
            switch (ItemID)
            {
                case 1:
                    PurchaseManager.BMagazin1 = true;
                    print(PurchaseManager.BMagazin1);
                    break;
                case 2:
                    PurchaseManager.BMagazin2 = true;
                    break;
                case 3:
                    PurchaseManager.BMagazin3 = true;
                    break;
                case 4:
                    PurchaseManager.BMagazin4 = true;
                    break;
                case 5:
                    PurchaseManager.BMagazin5 = true;
                    break;
                case 6:
                    PurchaseManager.BMagazin6 = true;
                    break;
                case 7:
                    PurchaseManager.BMagazin7 = true;
                    break;
                case 8:
                    PurchaseManager.BMagazin8 = true;
                    break;
                case 9:
                    PurchaseManager.BMagazin9 = true;
                    break;
                case 10:
                    PurchaseManager.BMagazin10 = true;
                    break;

            }

        }

    }
}
