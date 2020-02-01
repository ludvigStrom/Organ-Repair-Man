using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using FMODUnity;
public class TunableIntenstine : MonoBehaviour
{
    [SerializeField]
    private float currentFrequency;
    [SerializeField]
    private float aimFrequency;
    [SerializeField]
    private Player player;

    public float damage = 15;

    //FMOD Stuff
    private FMOD.Studio.EventInstance tuneforkEvent;
    private FMOD.Studio.EventInstance organ1Event;
    private FMOD.Studio.EventInstance organ2Event;
    private FMOD.Studio.EventInstance organ3Event;
    private FMOD.Studio.EventInstance organ4Event;
    private FMOD.Studio.EventInstance organ5Event;

    // Organ 1 = liver
    // Organ 2 = mjalte
    // Organ 3 = tarm
    // Organ 4 = heart
    // Organ 5 = lungs

    //FMOD Stuff End

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        tuneforkEvent = FMODUnity.RuntimeManager.CreateInstance("event:/SFX/soundingforkEvent");
        organ1Event = FMODUnity.RuntimeManager.CreateInstance("event:/SFX/tf_hitOrgan1Event");
        organ2Event = FMODUnity.RuntimeManager.CreateInstance("event:/SFX/tf_hitOrgan2Event");
        organ3Event = FMODUnity.RuntimeManager.CreateInstance("event:/SFX/tf_hitOrgan3Event");
        organ4Event = FMODUnity.RuntimeManager.CreateInstance("event:/SFX/tf_hitOrgan4Event");
        organ5Event = FMODUnity.RuntimeManager.CreateInstance("event:/SFX/tf_hitOrgan4Event");
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
        organ1Event.setParameterByName("pitch1", currentFrequency);
        organ1Event.start();
        
    }

    public float checkFrequency(float damage)
    {
        FMODUnity.RuntimeManager.PlayOneShot("event:/SFX/hpDamageEvent");
        tuneforkEvent.setParameterByName("pitch1", aimFrequency);
        tuneforkEvent.start();
        player.ReduceHealth(damage);
        return aimFrequency;
    }
}
