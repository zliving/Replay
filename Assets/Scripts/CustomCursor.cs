using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CustomCursor : MonoBehaviour {
	public Texture2D cursorTexture;
	public CursorMode cursorMode = CursorMode.Auto;
	public Vector2 hotSpot = Vector2.zero;

	// Start is the function we have to use instead of onMouseEnter because onMouseEnter is never called in our game.
	void Start() {
		// cursorTexture is whatever texture is assigned to this script
		Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
	}

	// Resets the mouse on exit to its default.
	void OnMouseExit() {
		Cursor.SetCursor(null, Vector2.zero, cursorMode);
	}
}