using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Exit : MonoBehaviour
{

    public void exit()
    {
        Application.Quit();
        Debug.Log("Adios");
    }


    public void StartNew()
    {
        SceneManager.LoadScene("HouseDay1");
    }

}
