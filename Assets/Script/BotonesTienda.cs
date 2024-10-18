using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BotonesTienda : MonoBehaviour
{

    [SerializeField]
    Tienda MyWallet;

    [SerializeField]
    TextMeshProUGUI textButton;

    [SerializeField]
    TextMeshProUGUI textoCompra;

    [SerializeField]
    string[] posiblesNombres;
    [SerializeField]
    string nameItem;
    [SerializeField]
    float priceItem;

    public int i;

    void Start()
    {
        //textButton = transform.GetChild(0).GetComponent<TextMeshProUGUI>();
        priceItem = Random.Range(25f, 350f);
        textButton.text = priceItem.ToString() + "€";
         i = Random.Range(0,4);
        // i = 3
        nameItem = posiblesNombres[i];
    }
    

    public void ClickEnBotonDeTienda()
    {
        MyWallet.RestarSaldo(priceItem);
        textoCompra.text = "¿Quieres Comprar " + nameItem.ToString() + " por " + priceItem + "€?";

    }
    public void adquicision()
    {
        MyWallet.RestarSaldo(priceItem);

    }
}
