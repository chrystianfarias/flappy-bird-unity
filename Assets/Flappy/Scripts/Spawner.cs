using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public GameObject parede;
    public bool ativo = false;
    public float velocidade = 2f;

    private float timer = 0;

    void Update () {
        if (ativo == false)
            return;

        timer += Time.deltaTime;
		if (timer >= 1.5f)
        {
            timer = 0f;
            CriarParede();
        }

        transform.Translate(Vector3.left * velocidade * Time.deltaTime);
    }
    void CriarParede()
    {
        GameObject novaParede = Instantiate(parede);
        novaParede.transform.SetParent(transform);
    }
}
