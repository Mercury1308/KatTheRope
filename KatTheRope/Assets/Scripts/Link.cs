using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Link : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            DestroyRope();
            Destroy(this);
        }
    }

    void DestroyRope()
    {
        Transform parentTransform = transform.parent;
        if (parentTransform != null)
        {
            int childCount = parentTransform.childCount;

            for (int i = 0; i < childCount; i++)
            {
                Transform child = parentTransform.GetChild(i);

                Destroy(child.gameObject);
            }
        }
        else
        {
            Debug.LogWarning("Bu objenin parent'i yok , silme işlemi yapılamıyor");
        }
    }
}


