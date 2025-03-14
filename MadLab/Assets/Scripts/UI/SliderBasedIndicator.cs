using System;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    public class SliderBasedIndicator : MonoBehaviour
    {
        [SerializeField] private Slider slider;

        public event Action<float> NewValueSet;
        
        public void Init(bool isWholeValue, int min, int max, float value)
        {
            slider.minValue = min;
            slider.maxValue = max;
            slider.wholeNumbers = isWholeValue;
            slider.value = value;
        }

        private void OnEnable()
        {
            slider.onValueChanged.AddListener((x) => NewValueSet?.Invoke(x));
        }

        private void OnDisable()
        {
            slider.onValueChanged.RemoveAllListeners();
        }
    }
}