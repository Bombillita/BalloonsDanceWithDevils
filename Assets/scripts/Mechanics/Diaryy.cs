using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Diaryy : MonoBehaviour
{
    public bool diary = false;
    public GameObject obj;
    public GameObject dialogopadre;
    public DialogueScripttwo ds;

    private void Update()
    {
        if (ds.dialoguefinished == true && diary == true)
        {
            obj.SetActive(false);
            ds.enabled = false;
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player") && Input.GetKeyDown(KeyCode.E))
        {
            diary = true;
            dialogopadre.SetActive(true);
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
