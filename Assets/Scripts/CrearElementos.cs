using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrearElementos : MonoBehaviour
{
    [SerializeField] GameObject crearEnemigo;
    [SerializeField] Camera camara;
    [SerializeField] Vector2 posicionMinima, posicionMaxima;
    // Start is called before the first frame update
    void Start()
    {
        camara = Camera.main;
        posicionMinima = camara.ViewportToWorldPoint(new Vector2(0, 0));
        posicionMaxima = camara.ViewportToWorldPoint(new Vector2(1, 1));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator CrearEnemigo()
    {
        while (true)
        {
            for(int i = 1; i <= 3; i++)
            {
                GameObject enemigo=
            }
        }
    }
}
