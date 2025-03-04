using MadLab.Effects;
using UnityEngine;
using UnityEngine.UI;

namespace MadLab.UI
{
    public class DelayIndicator : IntIndicatorWrapper
    {
        [SerializeField] private Slider slider;

        private void OnEnable()
        {
            slider.onValueChanged.AddListener(OnSliderValueChanged);
        }

        private void OnDisable()
        {
            slider.onValueChanged.RemoveListener(OnSliderValueChanged);
        }

        private void OnSliderValueChanged(float value)
        {
            Debug.Log($"Slider Value Changed: {value}");
        }
    }
}