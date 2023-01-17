using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SumarPuntos : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "enemigo")
        {
            Debug.Log("Hola");
            GameManager.Instancia.ActualizarPuntuacion(1);
            Debug.Log("Hola");
        }
    }
}
