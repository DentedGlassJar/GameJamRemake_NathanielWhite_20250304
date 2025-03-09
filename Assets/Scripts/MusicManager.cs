using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public AudioSource themeMusic;

    private void Start()
    {
        themeMusic.Play();     
    }
}
