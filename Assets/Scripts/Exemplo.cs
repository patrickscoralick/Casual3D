using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exemplo : MonoBehaviour
{
    public int pos_x = 5;
    public int pos_y = 7;

    void    Start ()
    {
        pos_x = multiplicaPorDois(pos_x);
        pos_y = multiplicaPorDois(pos_y);
        Debug.Log(pos_x);
        Debug.Log(pos_y);
    }

    int multiplicaPorDois (int numero)
    {
        int resultado;
        resultado = numero * 2;
        return (resultado);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            GetComponent<Renderer> ().material.color = Color.blue;
        }
        if (Input.GetKeyDown(KeyCode.W))
            GetComponent<Renderer> ().material.color = Color.green;
    }
}
 