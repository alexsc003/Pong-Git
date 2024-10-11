using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Trancurre : MonoBehaviour
{
    float tiempoTranscurrido = 0;
    [SerializeField]
    TextMeshProUGUI tiempoMostrado;
    [SerializeField]
    GameObject tiempoActivo;

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
                tiempoActivo.SetActive(false);
                tiempoMostrado.text = tiempoTranscurrido.ToString("00");
                tiempoTranscurrido = 0;
            }
            else
            {
            tiempoActivo.SetActive(true);
            }
        }
    }
}
