using UnityEngine;
using UnityEngine.EventSystems;

public class MoveControl : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
 	
	private bool isPressed;

    // Start is called before the first frame update
    
	public void OnPointerDown(PointerEventData eventData)
    {
        isPressed = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        isPressed = false;
    }
	
	public bool IsPressed()
    {
        return isPressed;
    }
}