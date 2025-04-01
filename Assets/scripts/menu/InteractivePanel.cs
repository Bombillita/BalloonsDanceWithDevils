using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractivePanel : MonoBehaviour
{

    public GameObject expanel;
    public bool caninteract = false;

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player") == true && caninteract == true)
        {
            expanel.SetActive(true);
        }
        else
        {
            expanel.SetActive(false);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            expanel.SetActive(false);
        }
    }

}
