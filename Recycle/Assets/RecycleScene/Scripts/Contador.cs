using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Contador : MonoBehaviour
{
    private int contadorColisiones = 0;
    public string caracteresEspecificos = "Bottle"; // Caracteres específicos a buscar en el nombre.

    private void OnTriggerEnter(Collider other)
    {

            // Verifica si el nombre del objeto 2 contiene los caracteres específicos.
            if (other.gameObject.name.Contains(caracteresEspecificos))
            {
                contadorColisiones++;
                Debug.Log("Colisiones: " + contadorColisiones);
            }
    }
}
