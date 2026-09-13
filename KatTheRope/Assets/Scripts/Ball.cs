using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ball : MonoBehaviour
{
    private Collider2D myCollider;
    private Renderer objectRenderer;
    void Start()
    {
        myCollider = GetComponent<Collider2D>();
        objectRenderer = GetComponent<Renderer>();

        if (myCollider == null)
        {
            Debug.LogError("Collider 2D bulunamadı");

        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "MainCharacter")
        {
            myCollider.enabled = false;
            objectRenderer.enabled = false;
            SceneController.instance.NextLevel();
        }

        if (collision.gameObject.name == "Ground")
        {
            int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

            SceneManager.LoadScene(currentSceneIndex);
        }


        if (collision.gameObject.name == "Obstacle")
        {
            int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

            SceneManager.LoadScene(currentSceneIndex);
        }


    }

}
