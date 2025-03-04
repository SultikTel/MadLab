namespace MadLab.Effects
{
    public class IntIndicatorWrapper : IndicatorWrapper
    {
        protected Indicator<int> indicator;

        public override object GetIndicator() => indicator;
    }
}