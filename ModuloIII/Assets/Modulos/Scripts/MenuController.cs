using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject imageOverlayQuit;
    void Start()
    {
        InitializeOverlays();        
    }

    private void InitializeOverlays()
    {
        imageOverlayQuit.SetActive(false);
    }
    
    public void BtnQuitGameOpenOverlay()
    {
        imageOverlayQuit.SetActive(true);
    }

    public void BtnReturnGameCloseOverlay()
    {
        imageOverlayQuit.SetActive(false);
    }

    public void BtnQuitGame()
    {
        Application.Quit();
        Debug.LogWarning("App closed");
    }

    public void BtnsOpenQuitOverlay()
    {
        if (imageOverlayQuit.activeSelf)
        {
            imageOverlayQuit.SetActive(false);
            Debug.LogWarning("Status Overlay = " + imageOverlayQuit.activeSelf);
        }
        else
        {
            imageOverlayQuit.SetActive(true);
             Debug.LogWarning("Status Overlay = " + imageOverlayQuit.activeSelf);
        }
    }


}
