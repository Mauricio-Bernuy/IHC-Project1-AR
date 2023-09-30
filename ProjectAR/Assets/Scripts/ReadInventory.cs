using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CW.Common;


namespace Lean.Gui
{

    [RequireComponent(typeof(LeanConstrainAnchoredPosition))]
    public class ReadInventory : MonoBehaviour
    {
        public GameObject screens;  
        private LeanConstrainAnchoredPosition _anchoredPosition;
        private string fileName;

        // Start is called before the first frame update
        void OnEnable()
        {
            // fileName = "inventory.txt";
            // fileName = Application.dataPath + "/inventory.txt";
            fileName = Application.persistentDataPath + "/inventory.txt";
    
            _anchoredPosition = screens.GetComponent<LeanConstrainAnchoredPosition>();

            if (File.Exists(fileName))
            {
                string[] plantsRecorded = File.ReadAllLines(fileName);  
                _anchoredPosition.HorizontalRectMin = plantsRecorded.Length * -1 + 1 ; 
                Debug.Log("YES FILE");

            }
            else{
                _anchoredPosition.HorizontalRectMin = 0; 
                Debug.Log("NO FILE");
            }
        }
    }

}
