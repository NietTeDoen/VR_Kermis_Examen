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
        foreach (Button But in SoldItems)
        {
            But.interactable = false;
        }
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
            int i = SoldItems.Length;
            if(SoldItems.Length > 0)
            {
                SoldItems.SetValue(ItemPurchase, SoldItems.Length - 1);

            } else
            {
                SoldItems.SetValue(ItemPurchase, SoldItems.Length);
            }
            print(SoldItems.Length);

        }

    }
}
