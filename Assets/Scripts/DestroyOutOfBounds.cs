using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float topBound = 30f;
    public float lowerBound = -10f;

    private void Update()
    {
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }

        else if (transform.position.z < lowerBound)
        {
            Destroy(gameObject);
            Time.timeScale = 0;
        }
    }
}
