using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Cronometro : MonoBehaviour
{
    [SerializeField]
    float cronometro = 0;
    [SerializeField]
    GameObject pausa;
    [SerializeField]
    GameObject detener;
    [SerializeField]
    TextMeshProUGUI numero;
    [SerializeField]
    GameObject tiempoActivo;

    // Update is called once per frame
    void Update()
    {
        if (tiempoActivo.activeSelf)
        { 
        cronometro = cronometro + Time.deltaTime;
        numero.text = cronometro.ToString();
        }
}
    public void Pausar()
    {
        if (tiempoActivo.activeSelf)
            tiempoActivo.SetActive(false);
        else
            tiempoActivo.SetActive(true);
    }
    public void Detener()
    {
        cronometro = 0;
        numero.text = cronometro.ToString();
        if (tiempoActivo.activeSelf)
            tiempoActivo.SetActive(false);
        else
            tiempoActivo.SetActive(true);
        
    }
    public void Tiempo()
    {
        numero.text = cronometro.ToString();
    }

}
