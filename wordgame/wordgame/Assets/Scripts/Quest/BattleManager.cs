using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleManager : MonoBehaviour
{
    public QuestManager questManager;
    public PlayerUIManager playerUI;
    public EnemyUIManager enemyUI;

    public PlayerManager player;
    EnemyManager enemy;


    private void Start()
    {
        enemyUI.gameObject.SetActive(false);
    }


    public void Setup(EnemyManager enemyManager)
    {
        enemyUI.gameObject.SetActive(true);
        enemy = enemyManager;
        enemyUI.SetupUI(enemy);
        playerUI.SetupUI(player);

        enemy.AddEventListenerOnTap(PlayerAttack);


    }

    void PlayerAttack()
    {
        //player to enemy
        player.Attack(enemy);
        enemyUI.UpdateUI(enemy);
        if(enemy.hp <=0)
        {
            enemyUI.gameObject.SetActive(false);
            Destroy(enemy.gameObject);
            EndBattle();
        }
        else
        {
            EnemyTurn();
        }

    }

    void EnemyTurn()
    {

        //enemy to player
        enemy.Attack(player);
        playerUI.UpdateUI(player);

    }

    void EndBattle()
    {
        questManager.EndBattle();

    }



}
