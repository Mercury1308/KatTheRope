using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hat : MonoBehaviour
{
    private Collider2D myCollider;
    public GameObject destination;
    void Start()
    {
        myCollider = GetComponent<Collider2D>();

        if (myCollider == null)
        {
            Debug.LogError("Collider2D bulunamadı obje: " + gameObject.name);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Şapkanın içinde" + other.gameObject.name);

        if (other.name == "Ball")
        {
            teleportToDestination(other.gameObject);

        }
        if (other.name == "Bubble")
        {
            Destroy(other.gameObject);
        }
    }

    void teleportToDestination(GameObject gameobject)
    {
        if (destination != null)
        {
            Vector2 position = destination.transform.position;
            gameobject.transform.position = position;
        }
    }

}
