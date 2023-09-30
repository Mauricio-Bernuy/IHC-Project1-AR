using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenInventory : MonoBehaviour
{
    public GameObject Panel;
    private string fileName;
    
    public void OpenPanel()
    {
        if(Panel != null)
        {
            fileName = Application.persistentDataPath + "/inventory.txt";

            if (File.Exists(fileName))
            {
                string[] plantsRecorded = File.ReadAllLines(fileName);  
                if (plantsRecorded.Length != 0)
                    Panel.SetActive(true);
              
            }
        }
    }
    public void ClosePanel()
    {
        if(Panel != null)
        {
            Panel.SetActive(false);
        }
    }
}
