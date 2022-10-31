using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score_system : MonoBehaviour
{

    
    public static int score;
    private bool HasFallen = false;
    public Text ScoreTXT;
    // Start is called before the first frame update
    void Start()
    {
        //ScoreTXT.text = score.ToString();
    }

    // Update is called once per frame
    void FixedUpdate()
    {

    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Ground" & !HasFallen)
        {
            score += 1;
            HasFallen = true;
            


        }
        
    }

}
