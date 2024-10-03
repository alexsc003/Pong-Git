using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Popup : MonoBehaviour
{
    [SerializeField]
    GameObject background;
    [SerializeField]
    GameObject popup;
    [SerializeField]
    float moveLocalY;
    [SerializeField]
    float timeanim;


   
    private void Start()
    {
        background.SetActive(false);
        popup.SetActive(false);
        
    }
    void Update()
    {
        if (popup == false)
        {
            transform.gameObject.popup(Vector3)
        }


        if (Input.GetKeyDown(KeyCode.Escape))
        {
            background.SetActive(!background.activeSelf);
            popup.SetActive(!popup.activeSelf);
            LeanTween.moveLocalY(popup, moveLocalY, timeanim).setEase(LeanTweenType.easeInBounce);
        }
    }
}
