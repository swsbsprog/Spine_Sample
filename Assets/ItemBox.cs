using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ItemBox : MonoBehaviour, IPointerDownHandler
{
    public Text itemNameText;
    public Image icon;

    public void OnPointerDown(PointerEventData eventData)
    {
        print($"{itemNameText.text}을 사용합니다");
        TurnManager.instance.EndHeroTurn();
    }

    internal void Init(Sprite item)
    {
        icon.sprite = item;
        itemNameText.text = item.name.Split("_")[^1];
    }
}
