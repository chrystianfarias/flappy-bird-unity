using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esfera : MonoBehaviour {

    void OnTriggerEnter(Collider other)
    {
        GetComponent<Renderer>().material.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
    }

    private void Update()
    {
        if (transform.position.y < -3f)
        {
            transform.position = new Vector3(0f, 3f, 0f);
            GetComponent<Rigidbody>().velocity = Vector3.zero;
        }
    }
}
