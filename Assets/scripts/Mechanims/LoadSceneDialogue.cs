using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScenedialogue : MonoBehaviour
{
    public string SceneName;          // Nombre de la escena a cargar
    public Collider dialogofinal;   // El objeto del diálogo
    public DialogueActivator daref;   // El script de activación del diálogo
    public GameManager gameManager;   // El GameManager que controla el estado del nivel

    // Método llamado cuando el jugador entra en el trigger
    private void OnTriggerEnter(Collider other)
    {
        // Comprobar que el objeto que entra es el jugador
        if (other.CompareTag("Player"))
        {
            Debug.Log("Jugador ha entrado en el trigger.");

            // Verificar si el nivel está completo
            if (gameManager.levelcompleted == true)
            {
                // Solo activar el diálogo si está desactivado
                if (!dialogofinal.enabled)
                {
                    Debug.Log("Activando diálogo");
                    dialogofinal.enabled=true;  // Activar el diálogo
                }
            }
            else
            {
                dialogofinal.enabled=false;   // Desactivar diálogo si el nivel no está completo
                Debug.Log("Nivel no completado.");
            }

            // Comprobar si el diálogo ha terminado para cambiar de escena
            StartCoroutine(EsperarYCambiarEscena());
        }
    }

    // Coroutine que espera a que termine el diálogo y luego cambia de escena
    private IEnumerator EsperarYCambiarEscena()
    {
        // Esperar hasta que el diálogo haya terminado
        while (!daref.dialoguefinished)
        {
            Debug.Log("Esperando a que termine el diálogo...");
            yield return null;  // Espera un frame antes de verificar nuevamente
        }

        // Una vez que el diálogo ha terminado, cambiar de escena
        Debug.Log("El diálogo ha terminado, cargando nueva escena");
        SceneManager.LoadScene(SceneName);
    }
}
