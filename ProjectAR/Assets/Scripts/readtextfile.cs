using System.Collections;
using System.Collections.Generic;
using System;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class readtextfile : MonoBehaviour
{
    private string fileName;
    public Text ttt;  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // fileName = "inventory.txt";
        // fileName = Application.dataPath + "/inventory.txt";
        fileName = Application.persistentDataPath + "/inventory.txt";

        if (File.Exists(fileName))
        {
            string plantsRecorded = File.ReadAllText(fileName);  
            Debug.Log(plantsRecorded);
            Debug.Log(fileName);
            ttt.text = plantsRecorded;
        }
    }
}