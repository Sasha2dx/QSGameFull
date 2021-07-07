using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{
    
    [SerializeField] private GameObject restartScreen;
    [SerializeField] private GameObject startScreen;
    [SerializeField] private GameObject darkScreenOverlay;

    public void ShowStartScreen()
    {
        startScreen.SetActive(true);
        darkScreenOverlay.SetActive(true);
    }
    
    public void ShowRestartScreen()
    {
        restartScreen.SetActive(true);
        darkScreenOverlay.SetActive(true);
    }
    
    public void HideUI()
    {
        startScreen.SetActive(false);
        restartScreen.SetActive(false);
        darkScreenOverlay.SetActive(false);
    }
}
