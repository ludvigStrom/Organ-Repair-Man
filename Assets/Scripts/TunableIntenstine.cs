using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TunableIntenstine : MonoBehaviour
{
    [SerializeField]
    private float currentFrequency;
    [SerializeField]
    private float aimFrequency;
    [SerializeField]
    private Player player;

    public float damage = 15;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
    }

    public float getCurrentPitch()
    {
        return currentFrequency;
    }

    public float getAimPitch()
    {
        return aimFrequency;
    }

    public void changeCurrentFrequency(float changeValue)
    {
        currentFrequency += changeValue;
    }

    public float checkFrequency(float damage)
    {
        player.ReduceHealth(damage);
        return aimFrequency;
    }
}
