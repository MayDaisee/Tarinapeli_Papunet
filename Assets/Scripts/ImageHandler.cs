using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Image = UnityEngine.UI.Image;

public class ImageHandler : MonoBehaviour
{
    public Image imageObject;
    public GameObject answers;
    public List<Sprite> imgs = new();

    private void Start()
    {
        IMGUpdate();

        Button[] buttons = answers.GetComponentsInChildren<Button>();

        foreach (Button button in buttons)
        {
            button.onClick.AddListener(() => IMGChange());
        }
    }


    void IMGUpdate()
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
