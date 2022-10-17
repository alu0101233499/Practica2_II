using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character2 : MonoBehaviour
{
    // Atributo público que definirá la velocidad de traslación.
    public float traslation;
    // Atributo público que definirá la velocidad de rotación.
    public float rotation;
    
    // Se llama al inicio de la ejecución.
    void Start()
    {
        traslation = 10f;
        rotation = 100f;
    }

    // Se llama en cada frame.
    void Update()
    {
        // Traslación.
        Vector3 move = new Vector3(0, 0, Input.GetAxis("Vertical2"));
        transform.Translate(move * traslation * Time.deltaTime);

        // Rotación.
        transform.Rotate(0, Input.GetAxis("Horizontal2") * rotation * Time.deltaTime, 0);
    }
}
