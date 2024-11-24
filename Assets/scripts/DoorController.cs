using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    public bool isinteractive = false;
    public bool delete = false;
    public bool hasKey = false;

    private void OnTriggerEnter(Collider other)
    {
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
