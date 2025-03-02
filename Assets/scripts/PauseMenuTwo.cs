using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenuTwo : MonoBehaviour
{
    [SerializeField] private GameObject emenu;
    [SerializeField] private GameObject gmenu;
    [SerializeField] private AudioSource audioSource; // El AudioSource donde se reproducirá el sonido
    private bool effectMenu = false;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
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

    // Métodos modificados para manejar el audio
    public void OpenE()
    {
        Time.timeScale = 0f;
        emenu.SetActive(true);
        gmenu.SetActive(false);
        effectMenu = true;

        // Reproducir el audio cuando se abre el menú
        audioSource.Play();
    }

    public void CloseE()
    {
        emenu.SetActive(false);
        gmenu.SetActive(true);
        effectMenu = false;
        Time.timeScale = 1f;

        // Reproducir el audio cuando se cierra el menú
        audioSource.Play();
    }
}
