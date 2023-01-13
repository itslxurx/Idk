using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverElemento : MonoBehaviour
{
    [SerializeField] Camera camara;
    [SerializeField] Vector2 posicionMinima, posicionInicial;
    [SerializeField] float velocidad = 2;
    // Start is called before the first frame update
    void Start()
    {
        camara = Camera.main;
        posicionMinima = camara.ViewportToWorldPoint(new Vector2(0, 0));
        posicionInicial = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * Time.deltaTime * velocidad);
        if (transform.position.x < posicionMinima.x)
        {
            transform.position = posicionInicial;
            velocidad = velocidad + 0.5f;
        }
    }
}
