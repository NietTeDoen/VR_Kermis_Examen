using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PurchaseManager : MonoBehaviour
{
    public Button Magazin1;
    public Button Magazin2;
    public Button Magazin3;
    public Button Magazin4;
    public Button Magazin5;
    public Button Magazin6;
    public Button Magazin7;
    public Button Magazin8;
    public Button Magazin9;
    public Button Magazin10;
    public Text ScoreTXT;

    public static bool BMagazin1 = false;
    public static bool BMagazin2 = false;
    public static bool BMagazin3 = false;
    public static bool BMagazin4 = false;
    public static bool BMagazin5 = false;
    public static bool BMagazin6 = false;
    public static bool BMagazin7 = false;
    public static bool BMagazin8 = false;
    public static bool BMagazin9 = false;
    public static bool BMagazin10 = false;

    // Start is called before the first frame update
    void Start()
    {
        PurchaseLoading();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PurchaseLoading()
    {
        if (BMagazin1)
        {
            Magazin1.interactable = false;
        }
        if (BMagazin2)
        {
            Magazin2.interactable = false;
        }
        if (BMagazin3)
        {
            Magazin3.interactable = false;
        }
        if (BMagazin4)
        {
            Magazin4.interactable = false;
        }
        if (BMagazin5)
        {
            Magazin5.interactable = false;
        }
        if (BMagazin6)
        {
            Magazin6.interactable = false;
        }
        if (BMagazin7)
        {
            Magazin7.interactable = false;
        }
        if (BMagazin8)
        {
            Magazin8.interactable = false;
        }
        if (BMagazin9)
        {
            Magazin9.interactable = false;
        }
        if (BMagazin10)
        {
            Magazin10.interactable = false;
        }
        ScoreTXT.text = "points: " + score_system.score.ToString();
    }
}
