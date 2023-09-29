using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plataforma : MonoBehaviour
{
    public float velocidadMovimiento = 5.0f; // Ajusta la velocidad según sea necesario.
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        // Obtén la entrada del usuario para el movimiento horizontal y vertical
        float movimientoHorizontal = Input.GetAxis("Horizontal");
        float movimientoVertical = Input.GetAxis("Vertical");

        // Calcula la velocidad del objeto 1
        Vector3 velocidad = new Vector3(0.0f, 0.0f, -1.0f) * velocidadMovimiento;

        // Aplica la velocidad al objeto 1
        rb.velocity = velocidad;
    }

}
