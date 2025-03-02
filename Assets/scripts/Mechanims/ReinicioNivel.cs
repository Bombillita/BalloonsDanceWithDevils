using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  // Necesario para recargar la escena

public class ReinicioNivel : MonoBehaviour
{
    // Método que se llama cuando el trigger detecta al jugador
    void OnTriggerEnter(Collider other)
    {
        // Verificamos si el objeto que colisionó es el jugador
        if (other.CompareTag("Player"))
        {
            // Llamamos a la función que reinicia el nivel
            ReiniciarNivel();
        }
    }

    // Función que reinicia el nivel actual
    void ReiniciarNivel()
    {
        // Obtener el nombre de la escena actual y recargarla
        string escenaActual = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(escenaActual);  // Recargar la escena actual
    }
}
