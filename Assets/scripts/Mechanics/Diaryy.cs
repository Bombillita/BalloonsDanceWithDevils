using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Diaryy : MonoBehaviour
{
    public bool diary = false;
    public GameObject obj;
    public GameObject dialogopadre;
    public GameObject coldialogo;



    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            diary = true;
            dialogopadre.SetActive(true);
            coldialogo.SetActive(true);
            obj.SetActive(false);

        }
    }


    public GameObject panel;

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            panel.SetActive(true);
        }

    }

    public void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            panel.SetActive(false);
        }

    }
}