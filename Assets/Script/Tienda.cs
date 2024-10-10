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
    int precioCantidad;
    void Start()
    {
        dineroCantidad = Random.Range(0,100);
        dinero.text = dineroCantidad.ToString();
        dineroCantidad = Random.Range(0, 50);
        precio.text = precioCantidad.ToString();
    }
}
