using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TunableIntenstine : MonoBehaviour
{

    public float currentFrequency;
    public float aimFrequency;

    private void Start()
    {
        
    }

    public float getCurrentPitch()
    {
        return currentFrequency;
    }

    public float getAimPitch()
    {
        return aimFrequency;
    }


}
