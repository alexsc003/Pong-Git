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

    public string SecondsToHours(float cronometro)
     {
         float hours = cronometro / 3600f;
         float restHours = cronometro % 3600f;
         float minutes = restHours / 60f;
        float seconds = minutes % 60f;
         int miliSeconds = (int)((seconds - (int)seconds) * 1000f);

         return hours.ToString("00") + " : " + minutes.ToString("00") + ":" + seconds.ToString("00")+ ":" + miliSeconds.ToString("00");
     }
    
    public void Tiempo()
    {
        numero.text = cronometro.ToString();
    }

}
