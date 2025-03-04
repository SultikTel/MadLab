using UnityEngine;

namespace MadLab.Effects
{
    public class VectorIndicatorWrapper : IndicatorWrapper
    {
        protected Indicator<Vector2> indicator = new Indicator<Vector2>();

        public override object GetIndicator() => indicator;
    }
}