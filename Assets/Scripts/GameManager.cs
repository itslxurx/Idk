using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instancia;
    [SerializeField] public int puntuacionActual, puntuacionMaxima;
    [SerializeField] float tiempo;
    [SerializeField] GameObject gameOver;
    [SerializeField] GameObject boton;
    [SerializeField] GameObject jugador;
    [SerializeField] GameObject enemigo;
    [SerializeField] bool cronometro;
    [SerializeField] TMP_Text textoTiempo;
    [SerializeField] MoverElemento moverElemento;
    // Start is called before the first frame update

    private void Awake()
    {
        if (Instancia == null)
        {
            Instancia = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(gameObject);
        }
        puntuacionMaxima = PlayerPrefs.GetInt("mejorPuntuacion");
    }

    void Start()
    {
        gameOver.SetActive(false);
        boton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (cronometro == true)
        {
            tiempo += Time.deltaTime;
            int minutos = (int)tiempo / 60;
            int segundos = (int)tiempo % 60;
            textoTiempo.text = minutos + "." + segundos;
        }
    }

    public void Perder()
    {
        jugador.SetActive(false);
        enemigo.SetActive(false);
        gameOver.SetActive(true);
        boton.SetActive(true);
        cronometro = false;
    }

    public void ReiniciarJuego()
    {
        puntuacionActual = 0;
        jugador.SetActive(true);
        enemigo.SetActive(true);
        gameOver.SetActive(false);
        boton.SetActive(false);
        tiempo = 0;
        cronometro = true;
        moverElemento.IniciarEnemigo();

    }

    public void ActualizarPuntuacion(int puntos)
    {
        Debug.Log(puntuacionActual);
        puntuacionActual += 1;
        if(puntuacionActual> puntuacionMaxima)
        {
            puntuacionMaxima = puntuacionActual;
            PlayerPrefs.SetInt("mejorPuntuacion", puntuacionMaxima);
        }
    }
}
