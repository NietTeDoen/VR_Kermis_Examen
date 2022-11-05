using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score_system : MonoBehaviour
{
    public GameObject CanHandler;
    public ResetScript RS;
    public static int score;
    private bool HasFallen = false;

    public void Start()
    {
        CanHandler = GameObject.FindGameObjectWithTag("CanScript");
        RS = CanHandler.GetComponent<ResetScript>();
    }

    public void OnTriggerEnter(Collider other)
    {if (other.tag == "Ground" & !HasFallen)
        { score += 1; HasFallen = true; 
            RS.coroutineStarter();}}
}