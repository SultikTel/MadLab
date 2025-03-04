using MadLab.Effects;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace MadLab.UI
{
    public class DelayIndicator : FloatIndicatorWrapper
    {
        [SerializeField] private Slider slider;
        [SerializeField] private TMP_Text valueText;

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
            indicator.Value = value;
            valueText.text = value.ToString("F2");
            Debug.Log($"Slider Value Changed: {value}");
        }
    }
}