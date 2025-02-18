using UnityEngine;

public class ArrowVisual : MonoBehaviour
{
    [SerializeField] private AngleIndicator angleIndicator;

    private void UpdateArrow(Vector2 direction)
    {
        if (direction == Vector2.zero)
            return;

        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        transform.rotation = Quaternion.Euler(0, 0, angle); 
    }

    private void OnEnable()
    {
        angleIndicator.newAngleSettled += UpdateArrow;
    }
    private void OnDisable()
    {
        angleIndicator.newAngleSettled -= UpdateArrow;
    }
}
