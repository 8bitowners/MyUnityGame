using System.Collections; 
using UnityEngine;
using TMPro;

public class DialogueUI : MonoBehaviour
{
    [SerializeField] private TMP_Text textLabel; 
    [SerializeField] private DialogueObject testDialogue; 
    [SerializeField] private GameObject dialogueBox; 

    private TypeWriterEffect typewriterEffect; 

    private void Start() {
        typewriterEffect = GetComponent<TypeWriterEffect>(); 
        CloseDialogueBox();
        ShowDialogue(testDialogue); 
    }
    public void ShowDialogue(DialogueObject dialogueObject) {
        dialogueBox.SetActive(true);
        StartCoroutine(routine:StepThroughDialogue(dialogueObject)); 
    }

    private IEnumerator StepThroughDialogue(DialogueObject dialogueObject) {
        foreach (string dialogue in dialogueObject.Dialogue) {
            yield return typewriterEffect.Run(dialogue, textLabel); 
            yield return new WaitUntil(()=> Input.GetKeyDown(KeyCode.Space)); 
        }
        CloseDialogueBox(); 
    }
    private void CloseDialogueBox() {
        dialogueBox.SetActive(false);
        textLabel.text=string.Empty; 
    }
}
