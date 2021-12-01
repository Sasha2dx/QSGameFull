using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{
    
    [SerializeField] private Animator restartScreen;
    [SerializeField] private Animator startScreen;
    [SerializeField] private Animator darkScreenOverlay;
    private static readonly int Show = Animator.StringToHash("show");

    public void ShowStartScreen()
    {
        startScreen.SetBool(Show,true);
        darkScreenOverlay.SetBool(Show,true);
    }
    
    public void ShowRestartScreen()
    {
        restartScreen.SetBool(Show,true);
        darkScreenOverlay.SetBool(Show,true);
    }
    
    public void HideUI()
    {
        startScreen.SetBool(Show,false);
        restartScreen.SetBool(Show,false);
        darkScreenOverlay.SetBool(Show,false);
    }
}
