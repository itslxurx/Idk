using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverElemento : MonoBehaviour
{
    [SerializeField] Camera camara;
    [SerializeField] Vector2 posicionMinima;
    [SerializeField] float velocidad;
    // Start is called before the first frame update
    void Start()
    {
        camara = Camera.main;
        posicionMinima = camara.ViewportToWorldPoint(new Vector2(0, 0));
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * Time.deltaTime * velocidad);
        if (transform.position.x < posicionMinima.x)
        {
            Destroy(gameObject, 0.5f);
        }
    }
}
