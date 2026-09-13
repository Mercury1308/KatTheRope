using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : MonoBehaviour
{
    public GameObject destination;
    private Collider2D myCollider;

    void Start()
    {
        myCollider = GetComponent<Collider2D>();

        if (myCollider == null)
        {
            Debug.LogError("Collider2D bulunamadı GameObejct: " + gameObject.name);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Ball")
        {
            moveStarToCounter(destination);
        }
    }

    void moveStarToCounter(GameObject gameObject)
    {
        Vector2 position = gameObject.transform.position;
        transform.position = position;
    }
}
