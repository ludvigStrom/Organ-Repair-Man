using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private TunableIntenstine[] instestines;
    [SerializeField]
    private bool gameOver;
    [SerializeField]
    private bool won;
    [SerializeField]
    private Player player;

    void Start()
    {
        GameObject p = GameObject.FindGameObjectWithTag("Player");
        player = p.GetComponent<Player>();

        gameOver = false;
        won = false;

        instestines = GetComponents<TunableIntenstine>();
    }

    void Update()
    {
        if (!player.IsAlive())
        {
            gameOver = true;
        }
        else
        {
            won = true;
        }        
    }


}
