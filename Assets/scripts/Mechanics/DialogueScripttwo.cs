using System.Collections;
using UnityEngine;
using TMPro;

public class DialogueScripttwo : MonoBehaviour
{
    public TextMeshProUGUI dialogueText;
    public string[] lines;
    public float textSpeed = 0.5f;
    private int index = 0;
    public GameObject infoPanel;
    private bool isPlayerInRange = false;  
    public bool dialoguefinished = true;

    public GameObject player;  
    private PlayerController playerController;  
    public bool CargaOtraEscena = false;
    public int OtraEscena;


    // Start is called before the first frame update
    void Start()
    {
        dialogueText.text = string.Empty;
        infoPanel.SetActive(false);  
        playerController = player.GetComponent<PlayerController>();  
    }

    // Update is called once per frame
    void Update()
    {
        if (isPlayerInRange && Input.GetKeyDown(KeyCode.E))  
        {
            if (!infoPanel.activeSelf)
            {
                StartDialogue();
            }
            else
            {
                // Si el diálogo ya está activo, avanzar al siguiente
                if (dialogueText.text == lines[index]) 
                {
                    NextLine();
                }
                else
                {
                    StopAllCoroutines(); // Detener cualquier escritura en curso
                    dialogueText.text = lines[index]; // Mostrar el texto completo inmediatamente
                }
            }
        }
    }

    // Inicia el diálogo
    public void StartDialogue()
    {
        playerController.moveSpeed = 0f;
        dialoguefinished = false;
        playerController.enabled = false;
        index = 0;  
        dialogueText.text = string.Empty; 
        infoPanel.SetActive(true);  
        StartCoroutine(WriteLine());
        
    }


    // Escribe la línea de diálogo
    IEnumerator WriteLine()
    {
        foreach (char letter in lines[index].ToCharArray())
        {
            dialogueText.text += letter;  
            yield return new WaitForSeconds(textSpeed);  
        }
    }

    // Avanzar a la siguiente línea
    public void NextLine()
    {
        if (index < lines.Length - 1)
        {
            index++;
            dialogueText.text = string.Empty; 
            StartCoroutine(WriteLine());  
        }
        else
        {
            EndDialogue();  
        }
    }

    // Cerrar el diálogo
    public void EndDialogue()
    {
        playerController.moveSpeed = playerController.moveSpeed;
        dialoguefinished =true;
        playerController.enabled = true;  

        infoPanel.SetActive(false);  
        if(CargaOtraEscena == true)
        {
            Application.LoadLevel(OtraEscena);
        }
    }

  
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))  
        {
            isPlayerInRange = true;  
        }
    }


    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerInRange = false; 
        }
    }
}
