using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIBattle : MonoBehaviour
{
    public Text infoText;
    public GameObject playerUI;
    Hero _selectedHero;
    public Transform weaponListParent;
    public Transform skillListParent;
    public Transform itemListParent;
    public ItemBox baseItem;
    internal void ShowInfo(string infoStr)
    {
        infoText.transform.parent.gameObject.SetActive(true);
        infoText.text = infoStr;
    }

    
    internal void ShowPlayerUI(Hero selectedHero)
    {
        playerUI.SetActive(true);
        _selectedHero = selectedHero;

        //selectedHero 가 가지고 있는 무기로 설정하자.
        SetItems(weaponListParent, selectedHero.useableWeapons);
        SetItems(skillListParent, selectedHero.useableSkills);
        SetItems(itemListParent, selectedHero.useableItems);
        weaponListParent.gameObject.SetActive(true);
    }

    internal void CloseUI()
    {
        playerUI.SetActive(false);
    }

    private void SetItems(Transform listParent, Sprite[] useable)
    {
        ItemBox[] oldItems = listParent.GetComponentsInChildren<ItemBox>();
        foreach (var item in oldItems)
            Destroy(item.gameObject);

        baseItem.gameObject.SetActive(true);
        foreach (var item in useable)
        {
            var newItem = Instantiate(baseItem, listParent);
            newItem.Init(item);
        }
        baseItem.gameObject.SetActive(false);
    }
}
