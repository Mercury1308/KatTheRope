using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Spider : MonoBehaviour
{
    public GameObject[] pathPoints;
    public float speed = 1f;
    public float rotationSpeed = 5f;
    public float rotationAngle = 90;
    private int currentPointIndex = 0;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        GameObject currentPoint = pathPoints[currentPointIndex];

        if (currentPoint != null && currentPointIndex + 1 <= pathPoints.Length)
        {
            Vector3 rotateDirection = currentPoint.transform.position - transform.position;

            float angle = Mathf.Atan2(rotateDirection.y, rotateDirection.x) * Mathf.Rad2Deg + rotationAngle;

            Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);

            transform.rotation = Quaternion.Slerp(transform.rotation, q, Time.deltaTime * rotationSpeed);

            Vector2 direction = pathPoints[currentPointIndex].transform.position - transform.position;

            transform.Translate(direction.normalized * speed * Time.deltaTime);

            if (Vector2.Distance(transform.position, currentPoint.transform.position) < 0.1f)
            {
                currentPointIndex = (currentPointIndex + 1) % pathPoints.Length;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Ball")
        {
            int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

            SceneManager.LoadScene(currentSceneIndex);
        }
    }
}
