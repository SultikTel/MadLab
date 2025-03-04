using MadLab.Effects;
using UnityEngine;
using UnityEngine.EventSystems;

namespace MadLab.UI
{
    public class AngleIndicator : VectorIndicatorWrapper, IPointerDownHandler, IPointerUpHandler, IDragHandler
    {
        [SerializeField] private RectTransform background;
        [SerializeField] private Arrow arrowIndicator;
        private Vector2 direction; 

        public void OnPointerDown(PointerEventData eventData)
        {
            MoveJoystick(eventData);
            arrowIndicator.UpdateArrow(direction);
        }

        public void OnDrag(PointerEventData eventData)
        {
            MoveJoystick(eventData);
            arrowIndicator.UpdateArrow(direction); 
        }

        public void OnPointerUp(PointerEventData eventData)
        {
            indicator.Value = direction;
            Debug.Log(direction);
            arrowIndicator.UpdateArrow(direction); 
        }

        private void MoveJoystick(PointerEventData eventData)
        {
            Vector2 localPoint;
            RectTransformUtility.ScreenPointToLocalPointInRectangle(background, eventData.position, eventData.pressEventCamera, out localPoint);
            direction = localPoint.normalized; 
        }
    }
}