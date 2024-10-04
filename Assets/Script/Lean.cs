using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lean : MonoBehaviour
{
    [SerializeField]
    float sizeToScale = 2f;
    [SerializeField]
    float durationAnim = 0.75f;
    [SerializeField]
    float movimientoY = 2.0f;
    [SerializeField]
    float movimientoX = 2000.0f;
    [SerializeField]
    float movimientoy = -2.0f;
    // Start is called before the first frame update
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        { 
            LeanTween.moveLocalY(gameObject, movimientoY, durationAnim).setEase(LeanTweenType.easeInBounce).setOnComplete(() => {

                LeanTween.moveLocalX(gameObject, movimientoX, durationAnim).setEase(LeanTweenType.easeInBounce).setOnComplete(() => {
            
                    LeanTween.moveLocalY(gameObject, movimientoy, durationAnim).setEase(LeanTweenType.easeInBounce).setOnComplete(() => {

                        LeanTween.moveLocalX(gameObject, -2.0f, durationAnim).setEase(LeanTweenType.easeInBounce);
            });
            });
            }); 
        }
}

    // Update is called once per frame
   
}
