using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plataforma : MonoBehaviour
{
    public Transform puntoInicial;
    public Transform puntoFinal;
    public float velocidad = 2.0f;

    private Vector3 objetivo;

    private void Start()
    {
        objetivo = puntoFinal.position;
    }

    private void Update()
    {
        // Mueve la plataforma hacia el objetivo
        transform.position = Vector3.MoveTowards(transform.position, objetivo, velocidad * Time.deltaTime);

        // Comprueba si la plataforma ha llegado al objetivo
        if (transform.position == objetivo)
        {
            // Teletransporta la plataforma al punto inicial
            objetivo = (objetivo == puntoFinal.position) ? puntoInicial.position : puntoFinal.position;
        }
    }
}
