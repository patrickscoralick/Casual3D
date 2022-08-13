using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
//using TMPro;


public class playerScript : MonoBehaviour
{
    private Rigidbody rbJogador;
    private float movimentoX;
    private float movimentoY;
    private float velocidade = 15.0f;
    private int pontos;
    //public TextMeshProUGUI placar;
    public Text placar;
    
    void Start()
    {
        rbJogador = GetComponent<Rigidbody>();
        pontos = 0;
        ContagemDoPlacar();
    } 
    
    void ContagemDoPlacar ()
    {
        placar.text = "Pontos: " + pontos.ToString();   
    }

    void OnMove (InputValue valorMovimento)
    {
        Vector2 vetorMovimento = valorMovimento.Get<Vector2>();
        movimentoX = vetorMovimento.x;
        movimentoY = vetorMovimento.y;
    }

    void FixedUpdate ()
    {
        Vector3 movimento = new Vector3(movimentoX, 0.0f, movimentoY);
        rbJogador.AddForce(movimento * velocidade);
    }

    void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.CompareTag("Moeda"))
        {
            other.gameObject.SetActive(false);
            pontos = pontos + 100; //pontos+= 100;
            ContagemDoPlacar();
        }
    }
}