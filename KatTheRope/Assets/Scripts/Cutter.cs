using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cutter : MonoBehaviour
{
    public GameObject objectToIgnore;
    void Start()
    {
        if (objectToIgnore != null)
        {
            Physics2D.IgnoreCollision(GetComponent<Collider2D>(), objectToIgnore.GetComponent<Collider2D>());
        }
        else
        {
            Debug.LogWarning("Boşlanacak obje bulunamadı");
        }
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 worldMousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        transform.position = worldMousePosition;
    }
}
