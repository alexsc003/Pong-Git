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
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (popup.activeSelf)
                UnshowPopUp();
            else
                ShowPopUp();
        }
        
    }
    public void ShowPopUp()
    {
        LeanTween.alphaCanvas(background.GetComponent<CanvasGroup>(), 1f, 2);
        background.SetActive(true);
        popup.SetActive(true);
        LeanTween.moveLocalY(popup, moveLocalY, timeanim).setEase(LeanTweenType.easeInBounce);
    }
    public void UnshowPopUp()
    {
        LeanTween.moveLocalY(popup, -1500.0f, 3).setEase(LeanTweenType.easeInBack).setOnComplete(()=>{
            background.SetActive(false);
        });
        LeanTween.alphaCanvas(background.GetComponent<CanvasGroup>(), 0f, timeanim).setOnComplete(() =>
        {
            popup.SetActive(false);
        });
        }
}
