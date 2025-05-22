using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class DiaryPage : MonoBehaviour
{
    [SerializeField] public GameObject diarypage;
    public bool read = false;
    public DialogueScripttwo ds;
    public bool rangeado = false;
    public bool estaopen = false;

    public void Update()
    {
        if (Input.GetKey(KeyCode.E) && rangeado == true)
        {
            diarypage.SetActive(true);
            estaopen = true;
        }

        if (estaopen == true)
        {
            rangeado = false;
            read = true;

            StartCoroutine(Quetecierres());
        }
  
    }


    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            rangeado = true;
        }
        else
        {
            rangeado = false;
        }
    }

    private IEnumerator Quetecierres()
    {
        if (rangeado == false && read == true)
        {
            yield return new WaitForSeconds (1f);

            if (Input.GetKey(KeyCode.E))
            {
                diarypage.SetActive(false);
                ds.enabled = true;
            }
        }
    }

}
