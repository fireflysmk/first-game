using UnityEngine;
using UnityEngine.EventSystems;

public class DebugButtonSearch : MonoBehaviour, IPointerEnterHandler
{
    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("Cursor on button!");
    }
}