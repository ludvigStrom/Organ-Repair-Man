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

    void OnMouseDown()
    {
        Debug.Log(this.gameObject.name +  "Current Frequence:" + currentFrequency + " aimFrequency:" + aimFrequency);
    }
}
