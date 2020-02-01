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
        Vector2 cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = cursorPos;
    }
}