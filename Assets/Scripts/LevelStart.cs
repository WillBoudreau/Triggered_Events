using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using UnityEngine.SceneManagement;

public class LevelStart : MonoBehaviour
{
    public GameObject LapTopTrue;
    public GameObject LapTopFalse;
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        LapTopFalse.SetActive(true);
        LapTopTrue.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void  OnTriggerEnter(Collider other)
    {
        StartLevel();
        Player.transform.position = new Vector3(4, 3, -13);
        LapTopTrue.SetActive(true);

    }
    private void StartLevel()
    {
        SceneManager.LoadScene(1);
        LapTopFalse.SetActive(false);
    }
}
