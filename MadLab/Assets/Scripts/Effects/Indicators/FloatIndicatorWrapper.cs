namespace MadLab.Effects
{
    public class FloatIndicatorWrapper : IndicatorWrapper
    {
        protected Indicator<float> indicator;

        public override object GetIndicator() => indicator;
    }

}