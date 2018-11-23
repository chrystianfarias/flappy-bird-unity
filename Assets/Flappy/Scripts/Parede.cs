using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parede : MonoBehaviour {
    private void Start()
    {
        Vector3 posicao = new Vector3(20f, Random.Range(-2.5f, 2.5f), 0f);
        transform.position = posicao;
    }
    private void Update()
    {
        if (transform.position.x < -20f)
        {
            Destroy(gameObject);
        }
    }
}
