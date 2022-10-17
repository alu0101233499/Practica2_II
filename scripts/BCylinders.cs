using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BCylinders : MonoBehaviour
{
    // Atributo privado que define la velocidad de traslación.
    private float translation = 100f;

    // Se ejecutará cuando un elemento colisione con el objeto.
    void OnTriggerEnter(Collider collider)
    {
        // En caso de que colisione el jugador, se moverán los cilindros.
        if (collider.gameObject.tag == "Jugador")
        {
            float xMovement = transform.position[0] - collider.gameObject.transform.position[0];
            float zMovement = transform.position[2] - collider.gameObject.transform.position[2];
            Vector3 direction = new Vector3(xMovement, 0f, zMovement);
            direction.Normalize();
            transform.Translate(direction * translation * Time.deltaTime);
        }
    }
}
