using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScenedialogue : MonoBehaviour
{
    public string SceneName;
    public GameObject dialogofinal;
    public DialogueActivator daref;

    public GameManager gameManager;

   private void OnTriggerEnter(Collider other)   
   {
        if (other.CompareTag("Player") && gameManager.levelcompleted == true)
        {
            dialogofinal.SetActive(true);
        }
        else
        {
            dialogofinal.SetActive(false);
        }

        if (daref.dialoguefinished == true)
        {
            SceneManager.LoadScene(SceneName);
            
        }   

   }
}