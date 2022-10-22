using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIBattle : MonoBehaviour
{
    public Text infoText;
    public GameObject playerUI;
    internal void ShowInfo(string infoStr)
    {
        infoText.transform.parent.gameObject.SetActive(true);
        infoText.text = infoStr;
    }

    internal void ShowPlayerUI()
    {
        playerUI.SetActive(true);
    }
}
