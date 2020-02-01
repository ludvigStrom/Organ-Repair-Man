using UnityEngine;
using System.Collections;

public class CursorManager : MonoBehaviour
{
    public bool hideCursor;

    private void Start()
    {
        Cursor.visible = hideCursor;
    }

    private void Update()
    {
        Vector3 pos = Input.mousePosition;
        pos.z = transform.position.z - Camera.main.transform.position.z;
        transform.position = Camera.main.ScreenToWorldPoint(pos);
    }
}