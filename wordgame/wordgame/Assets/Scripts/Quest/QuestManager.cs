﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestManager : MonoBehaviour
{
    // Start is called before the first frame update


    public StageUIManager stageUI;
    public GameObject enemyPrefab;
    public BattleManager battleManager;
    public SceneTrangitionManager SceneTrangitionManager;

    int[] encountTable = { -1, -1, 0, -1, 0, -1 };


    int currentStage = 0;

    private void Start()
    {
        stageUI.UpdateUI(currentStage);

    }

    public void OnNextButton()
    {
        currentStage++;

        //UIに反映
        stageUI.UpdateUI(currentStage);

        if (encountTable.Length <= currentStage)
        {
            Debug.Log("clear!");
            QuestClear();
        }

        else if (encountTable[currentStage] == 0)
        {
            EncounterEnemy();

        }


    }

    void EncounterEnemy()
    {
        stageUI.HideButtons();
        GameObject enemyObj = Instantiate(enemyPrefab);
        EnemyManager enemy = enemyObj.GetComponent<EnemyManager>();
        battleManager.Setup(enemy);


    }

    public void EndBattle()
    {
        stageUI.ShowButtons();
    }

    void QuestClear()
    {
        //クリア表示
        //街に戻るボタンだけ表示
        stageUI.ShowClearText();

        SceneTrangitionManager.LoadTo("Town");
    }

   
}
