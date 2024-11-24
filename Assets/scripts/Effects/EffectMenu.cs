using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectMenu : MonoBehaviour
{
    [SerializeField] private GameObject emenu;

    private bool openMenu = false;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (openMenu)
            {
                Close();
            }
            else
            {
                Open();
            }
        }

    }

    //metodos
    public void Open()
    {
        Time.timeScale = 0f;
        emenu.SetActive(true);
        openMenu = true;
    }

    public void Close()
    {
        emenu.SetActive(false);
        openMenu = false;
        Time.timeScale = 1f;

    }
}
