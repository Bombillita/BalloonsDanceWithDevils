using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSettings : MonoBehaviour
{
    public Transform player;
    public LayerMask obstacleLayer;

    // Listas de paredes por habitación
    public List<Renderer> habitacion1 = new List<Renderer>();
    public List<Renderer> habitacion2 = new List<Renderer>();
    public List<Renderer> habitacion3 = new List<Renderer>();

    private List<Renderer> paredesOcultas = new List<Renderer>(); //lista de paredes ocultas

    void Update()
    {
        Vector3 dir = transform.position - player.position;
        List<Renderer> nuevasParedesOcultas = new List<Renderer>();

        // Lanza el Raycast
        if (Physics.Raycast(player.position, dir, out RaycastHit hit, dir.magnitude, obstacleLayer))
        {

            if (habitacion1.Contains(hit.collider.GetComponent<Renderer>()))
            {
                nuevasParedesOcultas = habitacion1;
            }
            else if (habitacion2.Contains(hit.collider.GetComponent<Renderer>()))
            {
                nuevasParedesOcultas = habitacion2;
            }
            else if (habitacion3.Contains(hit.collider.GetComponent<Renderer>()))
            {
                nuevasParedesOcultas = habitacion3;
            }
        }

        foreach (Renderer pared in nuevasParedesOcultas)
        {
            if (!paredesOcultas.Contains(pared)) // si no esta oculta
            {
                pared.enabled = false;
            }
        }

        foreach (Renderer pared in paredesOcultas)
        {
            if (!nuevasParedesOcultas.Contains(pared)) 
            {
                pared.enabled = true;
            }
        }

        paredesOcultas = nuevasParedesOcultas;

        Debug.DrawRay(player.position, dir, Color.magenta);
    }
}
