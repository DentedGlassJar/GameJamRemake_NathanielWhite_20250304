using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    Vector3 spawnPoint;
    public AudioSource catHurt;
    // Start is called before the first frame update
    void Start()
    {
        spawnPoint = new Vector3(-6.4f, 7.5f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Buzzsaw"))
        {
            Debug.Log("Player has been moved back!");
            catHurt.Play();
            gameObject.transform.position = spawnPoint;     
        }
    }
}
