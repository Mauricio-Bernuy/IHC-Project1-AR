using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CW.Common;


public class DisplayInventory : MonoBehaviour
{
    public GameObject inventoryPrefab;  
    public GameObject[] ArPrefabs;

    private string fileName;
    public List<GameObject> _instantiatedPrefabs = new List<GameObject>();


    // Start is called before the first frame update
    void OnEnable()
    {
        // fileName = "inventory.txt";
        // fileName = Application.dataPath + "/inventory.txt";
        fileName = Application.persistentDataPath + "/inventory.txt";

        if (File.Exists(fileName))
        {
            string[] plantsRecorded = File.ReadAllLines(fileName);  
            int i = 0;
            foreach (string imageName in plantsRecorded)
            {
                var inventoryScreen = Instantiate(inventoryPrefab,transform);
                _instantiatedPrefabs.Add(inventoryScreen);

                inventoryScreen.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 0);
                inventoryScreen.GetComponent<RectTransform>().anchorMin = new Vector2(i, 0);
                inventoryScreen.GetComponent<RectTransform>().anchorMax = new Vector2(i+1, 1);

                i++;
                foreach (var curPrefab in ArPrefabs)
                {
                    if (string.Compare(curPrefab.name, imageName, StringComparison.Ordinal) == 0)
                    {
                        var newPrefab = Instantiate(curPrefab, inventoryScreen.transform.GetChild(5));
                        newPrefab.transform.GetChild(0).GetComponent<rotation>().enabled = true;
                        newPrefab.transform.GetChild(0).GetComponent<RotateToCamera>().enabled = false;
                        // _instantiatedPrefabs.Add(newPrefab);
                    }
                }

            }

            Debug.Log("YES FILE");

        }
        else{
            // _anchoredPosition.HorizontalRectMin = 0; 
            Debug.Log("NO FILE");
        }
    }

    void OnDisable()
    {
        foreach (var instaPrefab in _instantiatedPrefabs){
            Destroy(instaPrefab);
        }

    }
}
