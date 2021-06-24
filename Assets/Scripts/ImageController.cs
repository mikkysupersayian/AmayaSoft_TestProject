using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class ImageController : MonoBehaviour
{
    //This is a fade background which is only active once all 3 levels are complete
    public void SetActive() {

        transform.DORestart();
        transform.GetComponent<Image>().DOFade(1, 2).SetUpdate(true);
    }
}
