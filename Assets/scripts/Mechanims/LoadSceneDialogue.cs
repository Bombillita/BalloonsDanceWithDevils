using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScenedialogue : MonoBehaviour
{
    public GameManager gamemanager;
    public Collider colref;
    public DialogueScripttwo daref;
    public DialogueScripttwo daref2;
    public string scenename;
    public bool dialoguefinished = false;

    public bool onarea = false;

    private void Update()
    {

        dialoguefinished = daref.dialoguefinished;

        if (gamemanager.levelcompleted == true)
        {
            colref.enabled = true;
            daref2.enabled = false;

        }
        else
        {
            colref.enabled = false;
            daref.enabled = true;
        }

    }



    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            onarea = true;
            StartCoroutine(LoadLvel());
        }
        else
        {
            onarea = false;
        }
    }

    private IEnumerator LoadLvel()
     {

        if (Input.GetKeyDown(KeyCode.E))
        {
            yield return new WaitForSeconds(1);

            if (daref.dialoguefinished == true && onarea == true)
            {
                Debug.Log("PENE");
                SceneManager.LoadScene(scenename);
            }
        }
    } 
}




