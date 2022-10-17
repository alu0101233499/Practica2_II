using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubes : MonoBehaviour
{
    // Atributo privado que define un Vector3 para escalar el tamaño de los cubos.
    private Vector3 scale = new Vector3(0.5f, 0.5f, 0.5f);

    // Se ejecuta si detecta una colisión en el objeto.
    void OnCollisionEnter(Collision collision)
    {
        // Si el jugador colisiona, se reduce el tamaño.
        if (collision.gameObject.tag == "Jugador")
        {
            if (((transform.localScale - scale)[0] > 0) &&
                ((transform.localScale - scale)[1] > 0) &&
                ((transform.localScale - scale)[2] > 0))
            {
                transform.localScale = transform.localScale - scale;
            }
        }
        // Si el jugador 2 colisiona, se aumenta el tamaño.
        if (collision.gameObject.tag == "Jugador2")
        {
            transform.localScale = transform.localScale + scale;
        }
    }
}
