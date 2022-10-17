using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cylinders : MonoBehaviour
{
    // Atributo privado que define un Vector3 para escalar el tamaño de los cilindros.
    private Vector3 scale = new Vector3(0.5f, 0.5f, 0.5f);

     // Se ejecuta si detecta una colisión en el objeto.
    void OnCollisionEnter(Collision collision)
    {
        // Si el jugador colisiona, se aumenta el tamaño.
        if (collision.gameObject.tag == "Jugador")
        {
            transform.localScale = transform.localScale + scale;
        }
    }
}
