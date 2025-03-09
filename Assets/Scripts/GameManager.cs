using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    static GameManager instance;

    public AudioSource themeMusic;

    private void Start()
    {
        themeMusic.Play();
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(themeMusic);
        }
        else if (instance != this)
        {
            Destroy(themeMusic);
        }
        
    }
}
