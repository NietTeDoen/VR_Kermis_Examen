using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;
using UnityEngine.UI;

public class ResetScript : MonoBehaviour
{
    public GameObject CanPrefab;
    public GameObject Cans;
    public Text ScoreTXT;
    // Start is called before the first frame update
    void Start()
    {
        ScoreTXT.text = score_system.score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
        ScoreTXT.text = score_system.score.ToString();
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Ground")
        {
            GameObject.Destroy(Cans, 0.75f);
            Cans = Instantiate(CanPrefab);
            ScoreTXT.text = score_system.score.ToString();
        }
    }
}
