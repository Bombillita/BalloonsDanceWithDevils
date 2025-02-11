using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] private GameObject pmenu;
    private bool pauseMenu = false;
    public EffectMenu eref;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (pauseMenu)
            {
                CloseE();
            }
            else
            {
                OpenE();
            }
        }


        if (pauseMenu == true)
        {
            eref.CloseE();
        }

    }

    //metodos pene#led
    public void OpenE()
    {
        Time.timeScale = 0f;
        pmenu.SetActive(true);
        pauseMenu = true;
        eref.enabled = false;
    }

    public void CloseE()
    {
        pmenu.SetActive(false);
        pauseMenu = false;
        Time.timeScale = 1f;
        eref.enabled = true;

    }



}