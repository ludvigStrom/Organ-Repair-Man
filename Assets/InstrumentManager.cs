using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class InstrumentManager : MonoBehaviour
{
    public enum Instruments { HammerUp, HammerDown, TuningFork};
    public Instruments Instrument;
    public float damage = 10;
    public float tuneValue = 10;

    private CursorManager cursorManager;

    private void Start()
    {
        GameObject p = GameObject.FindGameObjectWithTag("CursorManager");
        cursorManager = p.GetComponent<CursorManager>();
    }


    void Update()
    {
        if (Input.GetKeyDown("q"))
        {
            cursorManager.SetCursor(0);
            print("q");
        }else if (Input.GetKeyDown("w"))
        {
            cursorManager.SetCursor(1);
            print("w");
        }else if (Input.GetKeyDown("e"))
        {
            cursorManager.SetCursor(2);
            print("e");
        }else if (Input.GetKeyDown("r"))
        {
            cursorManager.SetCursor(3);
            print("r");
        }

        Vector3 pos = Input.mousePosition;
        pos.z = transform.position.z - Camera.main.transform.position.z;
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(pos);
        RaycastHit2D hit = Physics2D.Raycast(new Vector2(mousePosition.x, mousePosition.y), new Vector2(), 0f);

        //mouse 0 tune up
        if (Input.GetMouseButtonDown(0) && !EventSystem.current.IsPointerOverGameObject())
        {
            if (hit.collider)
            {
                TunableIntenstine organ = hit.collider.gameObject.GetComponent<TunableIntenstine>();
                organ.changeCurrentFrequency(tuneValue);
                //Debug.Log(hit.collider.name + "Mouse 0, current freq, " + organ.getCurrentPitch());
            }
        }

        if (Input.GetMouseButtonDown(2) && !EventSystem.current.IsPointerOverGameObject())
        {
            if (hit.collider)
            {
                TunableIntenstine organ = hit.collider.gameObject.GetComponent<TunableIntenstine>();
                //Debug.Log(hit.collider.name + "Mouse 2, current freq, " + organ.getCurrentPitch());
                organ.checkFrequency(damage);
            }
        }

        //mouse 2 tune down
        if (Input.GetMouseButtonDown(1) && !EventSystem.current.IsPointerOverGameObject())
        {
            if (hit.collider)
            {
                TunableIntenstine organ = hit.collider.gameObject.GetComponent<TunableIntenstine>();
                organ.changeCurrentFrequency(tuneValue * -1);
                //Debug.Log(hit.collider.name + "Mouse 1, current freq, " + organ.getCurrentPitch());
            }
        }
    }
}