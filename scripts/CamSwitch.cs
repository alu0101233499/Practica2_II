using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamSwitch : MonoBehaviour
{
    // Atributo público que define la cámara 1.
    public GameObject cam1;
    // Atributo público que define la cámara 2.
    public GameObject cam2;

    // Se llama al inicio de la ejecución.
    void Start()
    {
        cam1.SetActive(true);
        cam2.SetActive(false);
    }

    // Se llama en cada frame.
    void Update()
    {
        // Cada vez que se pulse el botón de la cámara 1, ésta se activa.
        if (Input.GetButtonDown("Switch1"))
        {
            cam1.SetActive(true);
            cam2.SetActive(false);
        }
        // Cada vez que se pulse el botón de la cámara 2, ésta se activa.
        if (Input.GetButtonDown("Switch2"))
        {
            cam1.SetActive(false);
            cam2.SetActive(true);
        }
    }
}
