using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;
using UnityEngine.UI;
using Image = UnityEngine.UI.Image;

public class Choices : MonoBehaviour
{
    public static Choices instance;

    public Image BgImage;

    public List<string> choices = new();
    public List<Sprite> Bgs = new();

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        BGUpdate();

        Button[] buttons = GetComponentsInChildren<Button>();

        foreach (Button button in buttons)
        {
            TextMeshProUGUI choice = button.GetComponentInChildren<TextMeshProUGUI>();
            button.onClick.AddListener(() => AddToChoices(choice.text));
            button.onClick.AddListener(() => TextChange());
            button.onClick.AddListener(() => BGChange());
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
            TxtReader readerScript = reader.GetComponent<TxtReader>();

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

    void BGUpdate()
    {
        if (Bgs.Count > 0)
        {
            BgImage.sprite = Bgs[0];
            print("Image changed");
        }

        else
        {
            Debug.LogError("BG list not configd");
        }
    }

    public void BGChange()
    {
        if (Bgs.Count > 1)
        {
            Bgs.RemoveAt(0);
            BGUpdate();
        }
    }

}
