using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthSlider : MonoBehaviour
{
    public Player player;
    public Slider healthBar;
    public static float health;



    void Update()
    {
        healthBar.value = player.GetHealth() / player.GetMaxHealth();
        //Debug.Log(healthBar.value);
    }
}