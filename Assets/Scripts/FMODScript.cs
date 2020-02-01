using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FMODUnity;
public class FMODScript : MonoBehaviour
{
    // Start is called before the first frame update
    
    public float conductorHP;
    FMOD.Studio.EventInstance hplowEvent;


    private void Start()
    {
        hplowEvent = FMODUnity.RuntimeManager.CreateInstance("event:/SFX/hpLowEvent");
        hplowEvent.start();
    }


    // Update is called once per frame
    void Update()
    {
        
        var playerHealth = GameObject.Find("Body").GetComponent<Player>();
        conductorHP = playerHealth.playerHp;
        FMODUnity.RuntimeManager.StudioSystem.setParameterByName("hitpoints", conductorHP);
        Debug.Log("Current hitpoint param: " + conductorHP);

       
    }
}
