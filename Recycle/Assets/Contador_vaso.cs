using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Contador_vaso : MonoBehaviour
{
    private int contadorColisiones = 0;
    public string caracteresEspecificos = "Bottle"; // Caracteres específicos a buscar en el nombre.

    private void OnCollisionEnter(Collision collision)
    {

            // Verifica si el nombre del objeto 2 contiene los caracteres específicos.
            if (collision.gameObject.name.Contains(caracteresEspecificos))
            {
                contadorColisiones++;
                Debug.Log("Colisiones: " + contadorColisiones);
            }
    }
}
