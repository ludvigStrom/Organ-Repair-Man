using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    public float playerHp;

    [SerializeField]
    private float maxHealth;

    void Start()
    {
        maxHealth = 100;
        playerHp = maxHealth;
    }

    public float GetHealth()
    {
        return playerHp;
    }

    public bool IsAlive()
    {
        if(playerHp > 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public float GetMaxHealth()
    {
        return maxHealth;
    }

    public void ReduceHealth(float i)
    {
        //Debug.Log("Takes damage");
        playerHp -= i;
    }
}

