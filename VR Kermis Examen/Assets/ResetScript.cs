using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;
using UnityEngine.UI;
using UnityEngine.Audio;

public class ResetScript : MonoBehaviour
{
    public static bool GameObjectCount = false;
    public List<GameObject> CansList = new List<GameObject>();
    public GameObject[] CansAmmount = new GameObject[2];
    public GameObject prefabCans;
    public GameObject Cans;
    public GameObject ball;
    public GameObject prefabBall;
    public Text ScoreTXT;

    public static bool Audioplays;

    public AudioSource source;
    public AudioClip Aclip;

    void Start()
    {ScoreTXT.text = score_system.score.ToString();}

    void Update()
    {ScoreTXT.text = score_system.score.ToString(); 
        if (ball.transform.position.y <= -3)
        {
            GameObject.Destroy(ball); ball = Instantiate(prefabBall);
        }
    }
    public IEnumerator CanReset()
    {
        if (!Audioplays)
        {
            source.clip = Aclip;
            source.Play();
        }
        Audioplays = true;
        ScoreTXT.text = score_system.score.ToString(); GameObject.Destroy(Cans, 1.5f); yield return new WaitForSeconds(2f); GameObject.Destroy(ball); CansList.RemoveRange(0, CansList.Count);
        Cans = Instantiate(prefabCans); ball = Instantiate(prefabBall);
        GameObjectCount = false;
        Audioplays = false;
        yield return null; StopCoroutine("CanReset");
    }
    public void coroutineStarter(){
        if (!GameObjectCount) {
            GameObjectCount = true;
            foreach (GameObject CanGo in GameObject.FindGameObjectsWithTag("Cans"))
            {
                CansList.Add(CanGo);
                print(CansList.Count);
            }
        }
        
        
        if (CansList.Count > 15)
        {
            foreach (GameObject go in GameObject.FindGameObjectsWithTag("Cans"))
            {
                Destroy(go ,0.01f);
                print("error: there were more cans then 15 in the scene... removing cans");
            }
            CansList.RemoveRange(0, CansList.Count);
            StartCoroutine("CanReset");

        }
        else
        {
            StartCoroutine("CanReset");
        }
    }
}
