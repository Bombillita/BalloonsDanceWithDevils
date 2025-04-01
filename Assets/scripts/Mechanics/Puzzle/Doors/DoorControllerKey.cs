using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorControllerKey : MonoBehaviour
{
    public bool hasKey = false;

    void Start()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        //Si el objeto que entra no es el jugador, no sigue ejecutando la función
        if (other.CompareTag("Player") == false)
        {
            return;

        }

        if (hasKey == true)
        {
            gameObject.SetActive(false);
        }
        else
        {
            Debug.Log("necesitas una llave");
        }

    }

}
