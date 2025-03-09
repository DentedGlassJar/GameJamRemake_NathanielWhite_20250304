using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    Vector3 spawnPoint;
    public AudioSource catHurt;

    int sceneIndex;

    // Start is called before the first frame update
    void Start()
    {
        spawnPoint = new Vector3(-6.4f, 7.5f, 0f);

        sceneIndex = 0;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Buzzsaw"))
        {
            Debug.Log("Player has been moved back!");
            catHurt.Play();
            gameObject.transform.position = spawnPoint;     
        }

        if (collision.gameObject.CompareTag("Finish"))
        {
            SceneManager.LoadScene(sceneIndex++);
        }
    }
}
