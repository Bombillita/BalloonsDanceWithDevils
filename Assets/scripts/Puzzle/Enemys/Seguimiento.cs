using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Seguimiento : MonoBehaviour
{
    public Transform player;        // El jugador que el enemigo debe seguir
    private NavMeshAgent agent;     // Agente de navegación para mover al enemigo
    private bool isFollowing = false;  // Variable para saber si el enemigo debe seguir al jugador

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();  // Obtener el componente NavMeshAgent
    }

    // Update is called once per frame
    void Update()
    {
        // Si el enemigo debe seguir al jugador, establece la nueva posición de destino
        if (isFollowing)
        {
            agent.SetDestination(player.position);
        }
    }

    // Método para detectar cuando el jugador entra en el trigger
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))  // Verificar si el objeto es el jugador
        {
            isFollowing = true;  // El enemigo empieza a seguir al jugador
        }
    }

    // Método para detectar cuando el jugador sale del trigger
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))  // Verificar si el objeto es el jugador
        {
            isFollowing = false;  // El enemigo deja de seguir al jugador
        }
    }
}
