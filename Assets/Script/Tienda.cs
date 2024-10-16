using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Tienda : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI dinero;
    
    int dineroCantidad;
    
    [SerializeField]
    TextMeshProUGUI precio;
    [SerializeField]
    TextMeshProUGUI precio2;
    int precioCantidad;
    int precio2Cantidad;

    void Start()
    {
        dineroCantidad = Random.Range(0,100);
        dinero.text = dineroCantidad.ToString();
        precioCantidad = Random.Range(0,50);
        precio.text = precioCantidad.ToString();
        precio2Cantidad = Random.Range(0, 50);
        precio2.text = precioCantidad.ToString();
    }
}
