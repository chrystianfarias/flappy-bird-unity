using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    public Text text;
    private int pontos = 0;
    public Spawner spawner;
    public GameObject gameOverPanel;
    public GameObject inicioPanel;
    public bool gameOver = false;
    private AudioSource audioMoeda;

    private void Start()
    {
        audioMoeda = GetComponent<AudioSource>();
    }

    public void Iniciar()
    {
        spawner.ativo = true;
        inicioPanel.SetActive(false);
    }

    public void GameOver()
    {
        gameOver = true;
        spawner.ativo = false;
        gameOverPanel.SetActive(true);
    }
	
    public void AdicionarPonto()
    {
        pontos++;
        text.text = pontos.ToString();
        audioMoeda.Play();
    }

    public void IrDeNovo()
    {
        SceneManager.LoadScene(0);
    }
}
