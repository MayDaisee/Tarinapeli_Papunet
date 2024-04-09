using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

public class TSVReader : MonoBehaviour
{
    TextMeshProUGUI tmpAsset;
    
    public TextAsset dynamicText;
    List<string> ids = new ();


    private void Start()
    {
        tmpAsset = GetComponentInChildren<TextMeshProUGUI>();

        ReadTSV();
        UpdateText();
    }

    void UpdateText()
    {
        if (tmpAsset != null && ids.Count > 0)
        {

            tmpAsset.text = ids[0];

        }

        else
        {
            Debug.LogError("Text component not assigned!");
        }
    }
    
    void ReadTSV()
    {
        string[] lines = dynamicText.text.Split((char)KeyCode.Tab);

 
        foreach (string line in lines)
        {
            ids.Add(line);
        }
    }

    public void ChangeText()
    {
        
        if (ids.Count > 1)
        {
            ids.RemoveAt(0);
            
            UpdateText();
        }

        else
        {
            Debug.Log("No more lines!");
        }
    }

}
