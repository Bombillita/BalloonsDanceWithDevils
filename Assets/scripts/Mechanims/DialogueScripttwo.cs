using System.Collections;
using UnityEngine;
using TMPro;

public class DialogueScripttwo : MonoBehaviour
{
    public TextMeshProUGUI dialogueText;
    public string[] lines;
    public float textSpeed = 0.1f;
    private int index = 0;
    public GameObject infoPanel;
    private bool isPlayerInRange = false;  // Controla si el jugador está dentro del área

    public GameObject player;  // Referencia al objeto del jugador
    private PlayerController playerController;  // Componente de control del jugador

    // Start is called before the first frame update
    void Start()
    {
        dialogueText.text = string.Empty;
        infoPanel.SetActive(false);  // El panel de diálogo comienza desactivado
        playerController = player.GetComponent<PlayerController>();  // Obtener el componente PlayerController
    }

    // Update is called once per frame
    void Update()
    {
        if (isPlayerInRange && Input.GetKeyDown(KeyCode.E))  // Si el jugador está en rango y presiona "E"
        {
            // Si el diálogo no está iniciado aún, iniciar el diálogo
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
        // Desactivar el control de movimiento del jugador
        playerController.enabled = false;  // Desactivamos el script de control del jugador

        index = 0;  // Empezamos desde la primera línea
        dialogueText.text = string.Empty; // Limpiar el texto
        infoPanel.SetActive(true);  // Activar el panel de diálogo
        StartCoroutine(WriteLine());  // Comenzar a escribir la primera línea
    }

    // Escribe la línea de diálogo
    IEnumerator WriteLine()
    {
        foreach (char letter in lines[index].ToCharArray())
        {
            dialogueText.text += letter;  // Añadir letra por letra al texto
            yield return new WaitForSeconds(textSpeed);  // Pausa entre cada letra
        }
    }

    // Avanzar a la siguiente línea
    public void NextLine()
    {
        if (index < lines.Length - 1)
        {
            index++;
            dialogueText.text = string.Empty;  // Limpiar el texto
            StartCoroutine(WriteLine());  // Escribir la siguiente línea
        }
        else
        {
            EndDialogue();  // Si no hay más líneas, cerrar el diálogo
        }
    }

    // Cerrar el diálogo
    public void EndDialogue()
    {
        // Reactivar el control de movimiento del jugador
        playerController.enabled = true;  // Volvemos a activar el script de control del jugador

        infoPanel.SetActive(false);  // Desactivar el panel de diálogo
    }

    // Detectar cuando el jugador entra en el área de diálogo
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))  // Asegúrate de que el objeto tenga el tag "Player"
        {
            isPlayerInRange = true;  // El jugador está dentro del área
        }
    }

    // Detectar cuando el jugador sale del área de diálogo
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerInRange = false;  // El jugador salió del área
        }
    }
}
