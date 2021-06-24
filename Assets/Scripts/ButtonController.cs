using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class ButtonController : MonoBehaviour
{
    public GameObject gridController;
    public GameObject restartButton;
    public GameObject image;
    void Start()
    {
        gridController = GameObject.FindGameObjectWithTag("Grid");
        restartButton = GameObject.FindGameObjectWithTag("Restart");
        if (restartButton != null)
        {
            restartButton.SetActive(false);
        }
    }
    private void Update()
    {
        if (gridController.GetComponent<GridController>().level == 3)
        {

            image.SetActive(true);
            image.GetComponent<ImageController>().SetActive();
            restartButton.SetActive(true);
            
            gridController.SetActive(false);
            Time.timeScale = 0f;
        }
    }
}
