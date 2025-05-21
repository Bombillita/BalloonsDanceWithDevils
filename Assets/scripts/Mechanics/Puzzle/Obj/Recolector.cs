using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recolector : MonoBehaviour
{
    public int objetosRecolectados = 0;  
    public int objetosParaCompletarNivel = 4;  
    public float rangoRecolectar = 3f;  
    private GameObject objetoCercano;  
    public GameManager levelManger;

    // Update se llama una vez por frame
    void Update()
    {
      
        DetectarObjetoCercano();

     
        if (Input.GetKeyDown(KeyCode.E) && objetoCercano != null)
        {
            RecogerObjeto();
        }
    }

 
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
            objetosRecolectados++;  
            objetoCercano.SetActive(false);  

            // Mostrar cuántos objetos ha recogido el jugador
            Debug.Log("Objetos recolectados: " + objetosRecolectados);

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