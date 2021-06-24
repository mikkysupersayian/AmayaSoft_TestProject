using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class ButtonTest : MonoBehaviour
{
    public GameObject gridController;
    public GameObject restartButton;
    public Vector3 myVector;

    //If the Answer is correct, load next level, otherwise do a shake animation
    public void OnClick()
    {
        if(gameObject.GetComponent<Image>().sprite.name==gridController.GetComponent<GridController>().Answer)
        {
            
            if (gridController.GetComponent<GridController>().level == 0)
            {
                gridController.GetComponent<GridController>().mediumLevel();
                gridController.GetComponent<GridController>().level = 1;
            }
            else if (gridController.GetComponent<GridController>().level == 1)
            {
                gridController.GetComponent<GridController>().hardLevel();
                gridController.GetComponent<GridController>().level = 2;

            }
            else if (gridController.GetComponent<GridController>().level == 2) 
            {
                gridController.GetComponent<GridController>().level = 3;
            }
        }
        else
        {
            //When pressed wrong button
            transform.DORewind();
            transform.DOShakePosition(.5f,5).SetUpdate(true) ;

        }
    }
    private void Start()
    {
        gridController = GameObject.FindGameObjectWithTag("Grid");

    }

    
}
