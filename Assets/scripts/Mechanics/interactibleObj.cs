using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class interactibleObj : MonoBehaviour
{
    //public GameObject img;
    public bool caninteract = false;
    public Outline ooutline;

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player") == true && caninteract == true)
        {
            ooutline.enabled = true;
           // img.SetActive(true);
        }
        else
        {
           // img.SetActive(false);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            ooutline.enabled = false;
          //  img.SetActive(false);
        }
    }


}
