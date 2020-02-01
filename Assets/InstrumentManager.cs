using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class InstrumentManager : MonoBehaviour
{
    public enum Instruments { HammerUp, HammerDown, TuningFork};
    public Instruments Instrument;

    private GameObject currentObject;

    public float rayLength;
    public LayerMask layerMask;

    void Update()
    {
        Vector3 pos = Input.mousePosition;
        pos.z = transform.position.z - Camera.main.transform.position.z;
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(pos);
        RaycastHit2D hit = Physics2D.Raycast(new Vector2(mousePosition.x, mousePosition.y), new Vector2(), 0f);

        if (Input.GetMouseButtonDown(0) && !EventSystem.current.IsPointerOverGameObject())
        {
            if (hit.collider)
            {
                Debug.Log(hit.collider.name);
            }
        }
    }
}
