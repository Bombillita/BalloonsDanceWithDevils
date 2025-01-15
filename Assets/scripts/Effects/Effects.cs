using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Effects : MonoBehaviour
{
    //camera.main.viewporttoray();
    //refs
    public Thirdpersoncontroller tPC;
    public GameObject linterna;

    //bools efectos
    public bool skates = false;
    public bool chubasquero = false;
    public bool scissors = false;
    public bool atrapasuenos = false;
    public bool tirachinas = false;
    public bool trajedepureza = false;
    public bool lantern = false;

    //efecto linterna
    public bool effectOn = false;


    private void Update()
    {
        if (lantern == true)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                if (effectOn == false)
                {
                    linterna.SetActive(true);
                    effectOn = true;
                }
                else
                {
                    linterna.SetActive(false);
                    effectOn = false;
                }
            }
        }
        
        if (skates == true)
        {   
            if (Input.GetKeyDown(KeyCode.F))
            {
                if (effectOn == false)
                {
                    effectOn = true;
                }
                else
                {
                    effectOn = false;
                }

                if (effectOn == true)
                {
                   // tPC.
                }
            }
        }
        
    }


}
