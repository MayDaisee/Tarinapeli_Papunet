using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Image = UnityEngine.UI.Image;

public class ImageHandler : MonoBehaviour

{
    public static ImageHandler instance;

    public Image imageObject;
    public GameObject answers;
    public List<Sprite> imgs = new();

    public void Awake()
    {
        instance = this;
    }

    public void Start()
    {
        IMGUpdate();

        Button[] buttons = answers.GetComponentsInChildren<Button>();

        foreach (Button button in buttons)
        {
            button.onClick.AddListener(() => IMGChange());
        }
    }


    public void IMGUpdate()
    {
        if (imgs.Count > 0)
        {
            imageObject.sprite = imgs[0];
        }

        else
        {
            Debug.LogError("BG list not configd");
        }
    }

    public void IMGChange()
    {
        if (imgs.Count > 1)
        {
            imgs.RemoveAt(0);
            IMGUpdate();
        }
    }
}
