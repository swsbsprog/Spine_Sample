using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnManager : MonoBehaviour
{
    public static TurnManager instance; 
    public UIBattle uIBattle;
    public Hero selectedHero;
    public Transform seletedHeroCursor;
    void Start()
    {
        instance = this;    
        PlayerTurn();
    }

    private void PlayerTurn()
    {
        uIBattle.ShowInfo("플레이어 턴입니다");
        //첫번째 플레이어 선택
        SetSelectPlayer(selectedHero);
    }

    internal void SetSelectPlayer(Hero hero)
    {
        selectedHero = hero;
        seletedHeroCursor.transform.position = selectedHero.transform.position;
        uIBattle.ShowPlayerUI(selectedHero);
    }

    public void PassTurn()
    {
        // 적 턴 시작.
    }

    internal void EndHeroTurn()
    {
        uIBattle.CloseUI();
    }
}
