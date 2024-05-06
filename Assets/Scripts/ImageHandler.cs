using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
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
        print("nyt jysähti update");
        if (imgs.Count > 0)
        {
            print("Jee kuvia oli yli 0!");
            imageObject.sprite = imgs[0];
            print(imageObject.sprite);
        }

        else
        {
            Debug.LogError("BG list not configd");
        }
    }

    public void IMGChange()
    {
        print("pärähti nappula");
        if (imgs.Count > 1)
        {
            print("tuhoamme kuvan! :DDD");
            print(imgs.Count);
            imgs.RemoveAt(0);
            print("hehe" + imgs.Count);
            print("Kuvat tuhottu >:)))");
            IMGUpdate();
            
        }
        
    }
}
