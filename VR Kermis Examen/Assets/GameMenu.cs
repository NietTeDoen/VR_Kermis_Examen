using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Audio;

public class GameMenu : MonoBehaviour
{
    public Slider MasterVolume;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GoBackToMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void sliderchange()
    {
        AudioListener.volume = MasterVolume.value;
    }

    public void SavePlayer()
    {
        
    }

    public void loadplayer()
    {

    }
}
