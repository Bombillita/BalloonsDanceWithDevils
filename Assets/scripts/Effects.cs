using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Effects : MonoBehaviour
{
    //camera.main.viewporttoray();
    //refs
    public Thirdpersoncontroller tPC;

    //bools efectos
    public bool skates = false;
    public bool chubasquero = false;
    public bool scissors = false;
    public bool atrapasuenos = false;
    public bool tirachinas = false;
    public bool trajedepureza = false;

    //bools
    

    //llamar efecto

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            UsingEffect();
        }
    }

    private void UsingEffect()
    {
      if (skates == true)
        {
            Debug.Log("Hola");
            //tPC.moveSpeed = tPC.moveSpeed * 2f;
        }
    }
}
