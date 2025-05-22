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
            StartCoroutine(AdiosDiario());
        }
    }


    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.E))
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

    private IEnumerator AdiosDiario()
    {
        yield return new WaitForSeconds(0.5f);

        ds.enabled = false;

    }
}