using System;

namespace MadLab.Effects
{
    public class Indicator<T>
    {
        public event Action<T> OnValueChanged;
        private T value;

        public T Value
        {
            get => value;
            set
            {
                this.value = value;
                OnValueChanged?.Invoke(value);
            }
        }
    }
}