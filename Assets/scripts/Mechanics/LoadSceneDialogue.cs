using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScenedialogue : MonoBehaviour
{
    public GameManager gamemanager;
    public Collider colref;
    public DialogueScripttwo daref2;
    public string scenename;


    private void Update()
    {

        if (gamemanager.levelcompleted == true)
        {
            colref.enabled = true;
            daref2.enabled = false;

        }
        else
        {
            colref.enabled = false;

        }

    }


}