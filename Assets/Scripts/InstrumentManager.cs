using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class InstrumentManager : MonoBehaviour
{
    public enum Instruments { Hand, HammerUp, HammerDown, TuningFork};
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
            Instrument = Instruments.Hand;
            cursorManager.SetCursor(0);

        }else if (Input.GetKeyDown("w"))
        {
            Instrument = Instruments.TuningFork;
            cursorManager.SetCursor(1);

        }else if (Input.GetKeyDown("e"))
        {
            Instrument = Instruments.HammerUp;
            cursorManager.SetCursor(2);

        }else if (Input.GetKeyDown("r"))
        {
            Instrument = Instruments.HammerDown;
            cursorManager.SetCursor(3);

        }

        Vector3 pos = Input.mousePosition;
        pos.z = transform.position.z - Camera.main.transform.position.z;
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(pos);
        RaycastHit2D hit = Physics2D.Raycast(new Vector2(mousePosition.x, mousePosition.y), new Vector2(), 0f);

        if (Input.GetMouseButtonDown(0) && !EventSystem.current.IsPointerOverGameObject())
        {
            if (hit.collider)
            {
                TunableIntenstine organ = hit.collider.gameObject.GetComponent<TunableIntenstine>();
                
                if(Instrument == Instruments.HammerUp)
                {
                    organ.changeCurrentFrequency(tuneValue);
                }
                else if(Instrument == Instruments.HammerDown)
                {
                    organ.changeCurrentFrequency(tuneValue * -1);
                }
                else if (Instrument == Instruments.TuningFork)
                {
                    organ.checkFrequency(damage);
                }
            }
        }
    }
}