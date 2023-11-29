using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    private Queue <string> sentences;
    public TextMeshProUGUI Name;
    public TextMeshProUGUI Monologue;
    public GameObject MonologuePanel;
    // Start is called before the first frame update
    void Start()
    {
        MonologuePanel.SetActive(false);
        sentences = new Queue<string>();
    }

    
    public void StartMonolugue(Dialogue dialogue)
    {
        MonologuePanel.SetActive(true);
        Name.text = dialogue.name;

        sentences.Clear();

        foreach( string sentence in dialogue.sentences )
        {
            sentences.Enqueue(sentence);
        }
        DisplayNextSentence();

    }
    public void DisplayNextSentence()
    {
        if(sentences.Count == 0 )
        {
            EndMonologue();
            MonologuePanel.SetActive(false);
            return;
        }
        string sentence = sentences.Dequeue();
        Monologue.text = sentence;
    }
    void EndMonologue() 
    {

    }
}
