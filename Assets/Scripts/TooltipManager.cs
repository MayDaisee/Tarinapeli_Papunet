using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TooltipManager : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject TooltipSprite;

    public void OnPointerEnter(PointerEventData pointerEventData)
    {
        TooltipSprite.SetActive(true);
    }
    
    public void OnPointerExit(PointerEventData pointerEventData)
    {
        TooltipSprite.SetActive(false);
    }

    
}
