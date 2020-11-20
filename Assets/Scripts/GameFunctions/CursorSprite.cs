using UnityEngine;

public class CursorSprite : MonoBehaviour
{
    public Texture2D IdleCursorArrow;
    public Texture2D ClickedCursorArrow;
    Vector2 Offset = new Vector2(25, 10);

    void Start() => Cursor.SetCursor(IdleCursorArrow, Offset, CursorMode.ForceSoftware);
    private void Update() =>
        Cursor.SetCursor(Input.GetMouseButton(0) ? ClickedCursorArrow :
            IdleCursorArrow, Offset, CursorMode.ForceSoftware);
}