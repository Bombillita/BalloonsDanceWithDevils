using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjPicker : MonoBehaviour
{
    public GameObject tempItem;
    public TypeItem currenItem;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
  // Update is called once per frame
    void Update()
    {
        //Solo deja recoger el objeto si est� asignado a la variable
        //cuando temItem es null, no hay ning�n objeto cerca
        if(Input.GetKeyDown(KeyCode.E) && tempItem != null)
        {
            //Asignamos al obejto recogido el sctript ColorItem que llee el objeto
            currenItem = tempItem.GetComponent<TypeItem>();
            currenItem.Pick(this.transform);
            tempItem = null;
            return;

        }
        //Comprueba si hay alg�n valor asignado y lo puedes soltar
        if(Input.GetKeyDown(KeyCode.E) && currenItem != null)
        {
            currenItem.Drop();
            currenItem = null;
           
           
        }
    }
    private void OnTriggerEnter (Collider other)
    {
        if (other.CompareTag("Item") == true)
        {
            Debug.Log($"He encontrado el objeto {other.gameObject}");
            tempItem = other.gameObject;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (currenItem != null)
        {
            return; //skibidi toilet sigma ohio rizzler
        }
        if (other.CompareTag("Item") == true)
        {
            Debug.Log($"He alejado el objeto {other.gameObject}");
            tempItem = null;
        }
    }
  
}
