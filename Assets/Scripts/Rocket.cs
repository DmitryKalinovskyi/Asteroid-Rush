using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void OnCollisionEnter(Collision collision)
    {
        var obj = collision.gameObject;

        obj.SetActive(false);
    }
}
