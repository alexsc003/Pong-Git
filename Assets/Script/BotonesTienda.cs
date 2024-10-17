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
    string nameItem = "Objeto";
    [SerializeField]
    float priceItem;

    void Start()
    {
        textButton = transform.GetChild(0).GetComponent<TextMeshProUGUI>();
        priceItem = Random.Range(25f, 350f);
        textButton.text = priceItem.ToString() + "$";
    }

   
    public void ClickEnBotonDeTienda()
    {
        MyWallet.RestarSaldo(priceItem);
    }
}
