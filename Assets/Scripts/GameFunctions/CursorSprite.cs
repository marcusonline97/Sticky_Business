using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorSprite : MonoBehaviour
{

    public Texture2D IdleCursorArrow;
    public Texture2D ClickedCursorArrow;

    void Start()
    {
        Cursor.SetCursor(IdleCursorArrow, Vector2.zero, CursorMode.ForceSoftware);
        
    }
    private void Update()
    {
        ChangeSprite();


    }
    void ChangeSprite()
    {
        if (Input.GetMouseButton(0))
        {
            Cursor.SetCursor(ClickedCursorArrow, Vector2.zero, CursorMode.ForceSoftware);

        }
        else
        {
            Cursor.SetCursor(IdleCursorArrow, Vector2.zero, CursorMode.ForceSoftware);

        }
    }
}
