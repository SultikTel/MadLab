using System;
using UnityEngine;

namespace Effects
{
    public abstract class Indicator<T> : MonoBehaviour
    {
        public event Action<T> OnValueChanged;
        private T currentValue;

        

        protected void SetValue(T newValue)
        {
            if (!currentValue.Equals(newValue))
            {
                currentValue = newValue;
                OnValueChanged?.Invoke(currentValue);
            }
        }
    }
}