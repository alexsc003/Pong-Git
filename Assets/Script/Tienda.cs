using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Tienda : MonoBehaviour
{
    [SerializeField]
    float saldo;
    [SerializeField]
    TextMeshProUGUI labelSaldo;

    [SerializeField]
    GameObject confirmarCompra;
    [SerializeField]
    GameObject noSaldo;
    [SerializeField]
    float compra;
    

    void Start()
    {
        saldo = Random.Range(450f, 950f);
        labelSaldo.text = saldo.ToString("000.00") + "€";

    }
    public void RestarSaldo(float precioItem)
    {
        if (saldo > precioItem)
        {
            confirmarCompra.SetActive(true);
            compra = precioItem;
        }
        else
        {
            noSaldo.SetActive(true);
        }
    }
    public void Cerrar()
    {
        noSaldo.SetActive(false);
    }
    public void Cerrar2()
    {
        confirmarCompra.SetActive(false);
    }
    public void Compra(float precioItem)
    {
        if (saldo > compra)
        {       
        confirmarCompra.SetActive(false);
        saldo = saldo - compra;
        labelSaldo.text = saldo.ToString("000.00") + "€";
        }
        else
        {
            noSaldo.SetActive(true);
            confirmarCompra.SetActive(true);
        }
        
    }
}
