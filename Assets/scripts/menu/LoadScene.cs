using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public string SceneName;
    private void OnTriggerStay(Collider other)
    {
       if (Input.GetKeyDown(KeyCode.E) && other.CompareTag("Player"))
        { 
            
            SceneManager.LoadScene(SceneName);
        }
        
    }
}
