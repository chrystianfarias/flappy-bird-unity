using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Offset : MonoBehaviour {

    private Material material;
    private float offset = 0f;
    public float velocidade = 2f;
    private void Start()
    {
        material = GetComponent<Renderer>().material;
    }
    void Update () {
        offset += Time.deltaTime * velocidade;
        material.mainTextureOffset = new Vector2(offset, 1f);
	}
}
