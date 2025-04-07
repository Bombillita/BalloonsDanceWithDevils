using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bed : MonoBehaviour
{
    public DialogueScripttwo dialogue2;
    public Diaryy diary;
    public DialogueScript dialogref;
    public string SceneName;

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

}
