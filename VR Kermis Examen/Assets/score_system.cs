using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score_system : MonoBehaviour
{

    public GameObject Can;
    public static float score;
    private bool HasFallen = false;
    public Text ScoreTXT;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void FixedUpdate()
    {

    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Ground" & HasFallen == false)
        {
            score += 1;
            HasFallen = true;
            print("The can has fallen, current score: " + score);
            ScoreTXT.text = "Score: " + score;
        }
    }
}
