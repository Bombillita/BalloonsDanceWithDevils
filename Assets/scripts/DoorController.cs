using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    public bool isinteractive = false;
    public bool delete = false;
    public bool hasKey = false;
    public GameObject linterna;

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player") == false)
        {
            return;
        }

        if (hasKey == true && linterna.activeInHierarchy) 
        {
            gameObject.SetActive(false);
        }
        else
        {
            Debug.Log("necesitas una llave");

        }
    }
}
