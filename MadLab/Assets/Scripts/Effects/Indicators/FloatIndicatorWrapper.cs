namespace MadLab.Effects
{
    public class FloatIndicatorWrapper : IndicatorWrapper
    {
        protected Indicator<float> indicator = new Indicator<float>();

        public override object GetIndicator() => indicator;
    }

}