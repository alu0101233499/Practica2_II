using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    // Atributo público que definirá la velocidad de traslación.
    public float translation;
    // Atributo público que definirá la velocidad de rotación.
    public float rotation;
    // Atributo privado que definirá la puntuación.
    private int score;
    // Atributo privado que definirá los valores del movimiento de los cilindros tipo A en el eje X.
    private float xMovement;
    // Atributo privado que definirá los valores del movimiento de los cilindros tipo A en el eje Y.
    private float zMovement;

    // Se llama al inicio de la ejecución.
    void Start()
    {
        // Inicialización de los atributos.
        score = 0;
        translation = 10f;
        rotation = 100f;
    }

    // Se llama en cada frame.
    void Update()
    {
        // Traslación.
        Vector3 move = new Vector3(0, 0, Input.GetAxis("Vertical"));
        transform.Translate(move * translation * Time.deltaTime);

        // Rotación.
        transform.Rotate(0, Input.GetAxis("Horizontal") * rotation * Time.deltaTime, 0);

        // Alejar cilindros de tipo A al pulsar el espacio.
        if (Input.GetKeyDown("space"))
        {
            // Recuperación de todos los cilindros de tipo A.
            var cylinders = GameObject.FindGameObjectsWithTag("CilindroA");
            // Aplicación de movimiento a cada uno de ellos.
            foreach (var cylinder in cylinders)
            {
                xMovement = cylinder.gameObject.transform.position[0] - transform.position[0];
                zMovement = cylinder.gameObject.transform.position[2] - transform.position[2];
                Vector3 direction = new Vector3(xMovement, 0f, zMovement);
                direction.Normalize();
                cylinder.gameObject.transform.Translate(direction * (translation * 30) * Time.deltaTime);
            }
        }
    }

    // Se emplea para detectar colisiones con cilindros y aumentar la puntuación.
    void OnCollisionEnter (Collision collision) {
        if (collision.gameObject.tag == "Cilindro") {
            score++;
            Debug.Log("Puntuación: " + score.ToString());
        }
    }
}
