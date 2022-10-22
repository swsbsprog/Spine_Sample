using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnManager : MonoBehaviour
{
    public UIBattle uIBattle;
    void Start()
    {
        PlayerTurn();
    }

    private void PlayerTurn()
    {
        uIBattle.ShowInfo("플레이어 턴입니다");
        uIBattle.ShowPlayerUI();
        //todo : 첫번째 플레이어 선택
    }
    public void PassTurn()
    {
        // 적 턴 시작.
    }
}
