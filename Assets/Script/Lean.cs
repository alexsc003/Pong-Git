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
    // Start is called before the first frame update
    void Start()
    {
        LeanTween.scale(gameObject, Vector3.one * sizeToScale, durationAnim).setEase(LeanTweenType.easeInBounce);
        LeanTween.moveLocalY(gameObject, movimientoY, durationAnim).setEase(LeanTweenType.easeInBounce);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
