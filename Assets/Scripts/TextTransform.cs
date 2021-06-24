using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class TextTransform : MonoBehaviour
{
    //Fade In animation for text transformation
    public void FadeIn() {
        
        transform.DORestart();
        transform.GetComponent<Text>().DOFade(1,3).SetUpdate(true);

    }
}
