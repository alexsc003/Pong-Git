using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Contador : MonoBehaviour
{
    [SerializeField]
    GameObject cuentaObjecto;
    [SerializeField]
    float cuenta;
    [SerializeField]
    TextMeshProUGUI numero;
    float tiempoDeDesescalado = 0.0f;
    
    float tiempoDeEescalado = 0.5f;

    float desescalado = 0.0f;

    float escalado = 1.0f;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Cuenta();           
        }
        
    }

    public void Cuenta()
    {
        cuenta = cuenta + 1;
        LeanTween.scaleX(cuentaObjecto, desescalado, tiempoDeDesescalado).setEase(LeanTweenType.easeInBack);
        LeanTween.scaleY(cuentaObjecto, desescalado, tiempoDeDesescalado).setEase(LeanTweenType.easeInBack);             
                    LeanTween.scaleX(cuentaObjecto, escalado, tiempoDeEescalado).setEase(LeanTweenType.easeInBack);
                        LeanTween.scaleY(cuentaObjecto, escalado, tiempoDeEescalado).setEase(LeanTweenType.easeInBack);
                            
                                numero.text = cuenta.ToString();
               
    }
}
