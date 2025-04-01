using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectMenu : MonoBehaviour
{
    [SerializeField] private GameObject emenu;
    private bool effectMenu = false;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (effectMenu)
            {
                CloseE();
            }
            else
            {
                OpenE();
            }
        }

    }

    //metodos pene#led
    public void OpenE()
    {
        Time.timeScale = 0f;
        emenu.SetActive(true);
        effectMenu = true;
    }

    public void CloseE()
    {
        emenu.SetActive(false);
        effectMenu = false;
        Time.timeScale = 1f;

    }

}
