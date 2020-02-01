using UnityEngine;
using System.Collections;

public class CursorManager : MonoBehaviour
{
    public bool showCursor;
    public Sprite[] sprites;
    private SpriteRenderer spriteRenderer;
    private int currentSprite = 1;

    private void Start()
    {
        currentSprite = 1; //Start with sprite 1.
        spriteRenderer = this.gameObject.GetComponent<SpriteRenderer>();
        Cursor.visible = showCursor;
    }

    public void SetCursor(int i)
    {
        if(sprites[i] != null)
        {
            spriteRenderer.sprite = sprites[i];
        }
        else
        {
            Debug.Log("Sprite index out of range");
        }
    }

    public int GetCurrentSpriteIndex()
    {
        return currentSprite;
    }

    private void Update()
    {
        Vector3 pos = Input.mousePosition;
        pos.z = transform.position.z - Camera.main.transform.position.z;
        transform.position = Camera.main.ScreenToWorldPoint(pos);
    }
}