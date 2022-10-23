using Spine.Unity;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour
{
    Animator animator;

    public Sprite[] useableWeapons;
    public Sprite[] useableSkills;
    public Sprite[] useableItems;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void OnMouseDown()
    {
        TurnManager.instance.SetSelectPlayer(this);
    }
}
