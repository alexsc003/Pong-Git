using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Tienda : MonoBehaviour
{
    
    
    int dineroCantidad;

    [SerializeField]
    GameObject popUp;
    [SerializeField]
    GameObject noSaldo;
    [SerializeField]
    GameObject labelSaldo;

    [SerializeField]
    TextMeshProUGUI dinero;
    

    void Start()
    {
        dineroCantidad = Random.Range(0,100);
        dinero.text = dineroCantidad.ToString("000.00" + "$");
    }
    private void Update()
    {
        if (precioCantidad <= dineroCantidad)
        {
            dineroCantidad = dineroCantidad - precioCantidad;
        }
    }

    public void RestarSaldo(float precio)
    {
        if (dineroCantidad > precio)
        {
            dineroCantidad -= precio
                labelSaldo.text = RestarSaldo.ToString("000.00") + "$";
            else
            {
                noSaldo.SetActive(true);
            }
        }
    }
}
