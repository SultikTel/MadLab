using UnityEngine;

namespace MadLab.Effects
{
    public class VectorIndicatorWrapper : IndicatorWrapper
    {
        protected Indicator<Vector2> indicator;

        public override object GetIndicator() => indicator;
    }
}