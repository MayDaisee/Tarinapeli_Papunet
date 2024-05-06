using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeIn : MonoBehaviour
{

    CanvasGroup canvasGroup;
    public float delay = 2;
    float timer;

    bool isFading;

    private void Awake()
    {
        canvasGroup = GetComponent<CanvasGroup>();
        canvasGroup.alpha = 0;
        StartFade();
    }

    private void Update()
    {

        timer += Time.deltaTime;

        if (canvasGroup.alpha < 1 && timer >= delay && isFading)
        {

            canvasGroup.alpha += Time.deltaTime;

            if (canvasGroup.alpha == 1)
            {
                isFading = false;
            }

        }

    }

    public void StartFade()
    {
        timer = 0;
        canvasGroup.alpha = 0;
        isFading = true;
    }


}
