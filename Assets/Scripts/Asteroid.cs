using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    public Vector3 Direction;
    public float Velocity = 2f;

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position += Direction * Velocity * Time.deltaTime;
    }
}
