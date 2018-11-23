using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flappy : MonoBehaviour {

    private Rigidbody rigidbody;
    public GameController controller;
    private bool ativo = false;
    public Animation animacao;

    private AudioSource audioAsa;

    private void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        audioAsa = GetComponent<AudioSource>();
    }

	void Update () {
        if (ativo)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Impulso();
            }
            rigidbody.AddForce(Vector3.up * -0.8f, ForceMode.Impulse);
        }
        else
        {
            if (controller.gameOver == false)
            {
                if (Input.GetMouseButtonDown(0))
                {
                    controller.Iniciar();
                    ativo = true;
                    rigidbody.isKinematic = false;
                    Impulso();
                }
            }
        }
    }

    void Impulso()
    {
        rigidbody.AddForce(Vector3.up * (15f + rigidbody.velocity.y * -1), ForceMode.Impulse);
        audioAsa.Play();
        animacao.Stop();
        animacao.Play();
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.transform.tag == "GameOver")
        {
            controller.GameOver();
            rigidbody.constraints = RigidbodyConstraints.None;
            ativo = false;
        }
            
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Ponto")
        {
            controller.AdicionarPonto();
        }
    }
}
