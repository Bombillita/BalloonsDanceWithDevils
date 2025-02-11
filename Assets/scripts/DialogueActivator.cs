using System.Collections;
using UnityEngine;
using TMPro;

public class DialogueActivator : MonoBehaviour
{
    public TextMeshProUGUI dialogueText;
    public string[] lines;
    public float textSpeed = 0.1f;
    private int index = 0;
    public GameObject infoPanel;
    private bool isPlayerInRange = false;

    public GameObject player;
    private Thirdpersoncontroller tpc;

    void Start()
    {
        dialogueText.text = string.Empty;
        infoPanel.SetActive(false);
        tpc = player.GetComponent<Thirdpersoncontroller>();
    }


    void Update()
    {

        if (isPlayerInRange && Input.GetKeyDown(KeyCode.E))
        {
            if (dialogueText.text == lines[index])
            {
                NextLine();
            }
            else
            {
                StopAllCoroutines();
                dialogueText.text = lines[index];
            }
        }
    }

    public void StartDialogue()
    {

        tpc.enabled = false;
        index = 0;
        dialogueText.text = string.Empty;
        infoPanel.SetActive(true);
        StartCoroutine(WriteLine());
    }
    IEnumerator WriteLine()
    {
        foreach (char letter in lines[index].ToCharArray())
        {
            dialogueText.text += letter;
            yield return new WaitForSeconds(textSpeed);
        }
    }


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


    public void EndDialogue()
    {

        tpc.enabled = true;

        infoPanel.SetActive(false);
        gameObject.SetActive(false);
    
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerInRange = true;
            StartDialogue();
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