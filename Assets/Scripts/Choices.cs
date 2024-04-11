using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;
using UnityEngine.UI;

public class Choices : MonoBehaviour
{
    public static Choices instance;

    public List<string> choices = new();

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        Button[] buttons = GetComponentsInChildren<Button>();

        foreach (Button button in buttons)
        {
            TextMeshProUGUI choice = button.GetComponentInChildren<TextMeshProUGUI>();
            button.onClick.AddListener(() => AddToChoices(choice.text));
            button.onClick.AddListener(() => TextChange());
        }
    }


    public void AddToChoices(string choice)
    {
        choices.Add(choice);

    }

    public void TextChange()
    {
        GameObject[] readers = GameObject.FindGameObjectsWithTag("Reader");

        foreach (GameObject reader in readers)
        {
            TSVReader readerScript = reader.GetComponent<TSVReader>();

            if (readerScript != null)
            {
                readerScript.ChangeText();
            }

            else
            {
                Debug.LogWarning("No reader script in tagged object");
            }
        }

    }


}
