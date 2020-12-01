using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class GestureClick : MonoBehaviour, IPointerClickHandler
{
    public UnityEvent<Vector3> OnClick;
    public void OnPointerClick(PointerEventData eventData)
    {
        OnClick.Invoke(eventData.pointerPressRaycast.worldPosition);
    }
}

    
