using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrastre : MonoBehaviour
{
    public float coeficienteDeFriccion = 1.0f; // Ajusta este valor según sea necesario.
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnCollisionStay(Collision collision)
    {
        // Verifica si el objeto con el que colisionamos es el objeto 1
        if (collision.gameObject.CompareTag("FloorMetalPanelChamferedHalf"))
        {
            // Calcula la velocidad relativa entre los objetos
            Vector3 velocidadRelativa = rb.velocity - collision.rigidbody.velocity;

            // Calcula la fuerza de fricción
            Vector3 fuerzaFriccion = -coeficienteDeFriccion * velocidadRelativa;

            // Aplica la fuerza de fricción al objeto 2
            rb.AddForce(fuerzaFriccion);
        }
    }
}
