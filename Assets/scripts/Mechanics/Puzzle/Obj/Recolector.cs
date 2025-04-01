using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recolector : MonoBehaviour
{
    public int objetosRecolectados = 0;  // Cuenta cuántos objetos ha recogido el jugador
    public int objetosParaCompletarNivel = 4;  // Número de objetos necesarios para completar el nivel
    public float rangoRecolectar = 3f;  // Distancia para detectar los objetos recolectables
    private GameObject objetoCercano;  // El objeto cercano que puede ser recogido
    public GameManager levelManger;

    // Update se llama una vez por frame
    void Update()
    {
        // Detectar el objeto más cercano dentro del rango
        DetectarObjetoCercano();

        // Si el jugador presiona "E" y hay un objeto cercano, lo recoge
        if (Input.GetKeyDown(KeyCode.E) && objetoCercano != null)
        {
            RecogerObjeto();
        }
    }

    // Detecta el objeto más cercano dentro del rango de recolección
    private void DetectarObjetoCercano()
    {
        float distanciaMinima = rangoRecolectar;
        objetoCercano = null;

        // Buscar objetos con el tag "Recolectable" dentro del rango
        Collider[] objetosEnRango = Physics.OverlapSphere(transform.position, rangoRecolectar);

        foreach (Collider col in objetosEnRango)
        {
            if (col.CompareTag("Item"))
            {
                float distancia = Vector3.Distance(transform.position, col.transform.position);
                if (distancia < distanciaMinima)
                {
                    distanciaMinima = distancia;
                    objetoCercano = col.gameObject;  // Asignar el objeto más cercano
                }
            }
        }
    }

    // Método para recoger el objeto
    private void RecogerObjeto()
    {
        if (objetoCercano != null)
        {
            objetosRecolectados++;  // Aumentar el contador de objetos recolectados
            objetoCercano.SetActive(false);  // Destruir el objeto recogido

            // Mostrar cuántos objetos ha recogido el jugador
            Debug.Log("Objetos recolectados: " + objetosRecolectados);

            // Verificar si el jugador ha recogido suficientes objetos
            if (objetosRecolectados >= objetosParaCompletarNivel)
            {
                CompletarNivel();
            }
        }
    }

    // Método que se llama cuando se completa el nivel
    private void CompletarNivel()
    {
        levelManger.levelcompleted = true;
    }
}