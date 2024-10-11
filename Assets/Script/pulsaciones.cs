using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class pulsaciones : MonoBehaviour
{
    float tiempoTranscurrido = 0;
    [SerializeField]
    TextMeshProUGUI tiempoMostrado;
    [SerializeField]
    GameObject tiempoActivo;
    float numeroDePulsasiones;

    void Update()
    {
        if (tiempoActivo.activeSelf)
        {
            tiempoTranscurrido = tiempoTranscurrido + Time.deltaTime;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (tiempoActivo.activeSelf)
            {
                numeroDePulsasiones = numeroDePulsasiones + 1;
            }
        }
        if (tiempoTranscurrido <= 15f)
            tiempoMostrado.text = numeroDePulsasiones.ToString("00");
            tiempoActivo.SetActive(false);
        
    }
    public void Detener()
    {
        tiempoActivo.SetActive(true);
        numeroDePulsasiones = 0;        
    }
}
