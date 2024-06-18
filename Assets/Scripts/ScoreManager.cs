using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text Puntuacion;
    private int puntos;

    void Start()
    {
        puntos = 0;
        ActualizarTexto();
    }

    public void AddPoints(int points)
    {
        puntos += points;
        ActualizarTexto();
    }

    void ActualizarTexto()
    {
        Puntuacion.text = "Puntuacion: " + puntos.ToString();
    }
}
