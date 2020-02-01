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

    private bool isTuned = false;


    void Start()
    {
        isTuned = false;
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
            if (CheckTuning())
            {
                won = true;
            }
        }

        if (won == true) {
            FMODUnity.RuntimeManager.PlayOneShot("event:/SFX/winChord");
        }
    }

    bool CheckTuning()
    {

        foreach (TunableIntenstine intestine in instestines)
        {
            if(intestine.getCurrentPitch() / intestine.getAimPitch() >= 0.95)
            {
                isTuned = true;
            }
            else
            {
                isTuned = false;
            }
        }

        return isTuned;
    }
}
