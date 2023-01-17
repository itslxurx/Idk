using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] TMP_Text puntuacionActual, puntuacionMaxima, tiempo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        puntuacionActual.text = GameManager.Instancia.puntuacionActual.ToString();
        puntuacionMaxima.text = GameManager.Instancia.puntuacionMaxima.ToString();
    }
}
