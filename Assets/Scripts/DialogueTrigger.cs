using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue;

    public void TriggerMonologue()
    {
        FindObjectOfType<DialogueManager>().StartMonolugue(dialogue);
    }
    
}
