using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractToUnlock : MonoBehaviour
{
    public GameObject objtobreak;
    public bool hasInteractedd = false;

    private void Update()
    {
        if (hasInteractedd == true)
        {
            objtobreak.SetActive(false);
        }
    }


    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player") && hasInteractedd == false)
        {
            hasInteractedd = true;
        }
        else
        {
            hasInteractedd = false;
        }


    }

}
