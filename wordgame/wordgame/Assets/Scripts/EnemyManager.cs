using System;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    Action tapAction;//クリックした時に実行、外部から

    public new string name;
    public int hp;
    public int at; 

    //attack
    public void Attack(PlayerManager player)
    {
        player.Damage(at);
    }

    //damage
    public void Damage(int damage)
    {
        hp -= damage;
        if(hp <= 0)
        {
            hp = 0;
        }

    }

    //tapActionに関数を登録する関数を作る
    public void AddEventListenerOnTap(Action action)
    {
        tapAction += action;
    }



    public void OnTap()
    {
        Debug.Log("クリック");
        tapAction();
    }


    
   
}
