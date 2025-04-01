using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bed : MonoBehaviour
{
    public Collider dialogue2;
    public Diaryy diary;
    public DialogueScript dialogref;
    public string SceneName;

    // Update is called once per frame
    void Update()
    {
        if (diary.diary == true)
        {
            dialogue2.enabled = true;
            dialogref.enabled = false;
        }
        else
        {
            dialogref.enabled = true;
            dialogue2.enabled=false;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (diary.diary == true && other.CompareTag("Player") && Input.GetKeyDown(KeyCode.E))
        {
            SceneManager.LoadScene(SceneName);
        }
    }
}
