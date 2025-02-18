using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class AngleIndicator : Indicator, IPointerDownHandler, IPointerUpHandler, IDragHandler
{
    [SerializeField] private RectTransform background;
    [SerializeField] private RectTransform handle;

    public Action<Vector2> newAngleSettled;

    private float radius;
    private Vector2 direction; 

    private void Start()
    {
        radius = background.sizeDelta.x / 2;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        MoveJoystick(eventData);
        newAngleSettled?.Invoke(direction);
    }

    public void OnDrag(PointerEventData eventData)
    {
        MoveJoystick(eventData);
        newAngleSettled?.Invoke(direction);
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        Debug.Log($"Joystick Direction: {direction}");
        newAngleSettled?.Invoke(direction);
    }

    private void MoveJoystick(PointerEventData eventData)
    {
        Vector2 localPoint;
        RectTransformUtility.ScreenPointToLocalPointInRectangle(background, eventData.position, eventData.pressEventCamera, out localPoint);

        direction = localPoint.normalized; 
        handle.anchoredPosition = direction * radius; 
    }
}
