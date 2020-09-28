using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public new string name;
    public int hp;
    public int at; 

    public void OnTap()
    {
        Debug.Log("click");
    }
    
    
    //attack
    public void Attack(PlayerManager player)
    {

    }

    //damage
    public void Damage(int damage)
    {
        hp -= damage;

    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
