namespace MadLab.Effects
{
    public class IntIndicatorWrapper : IndicatorWrapper
    {
        private Indicator<int> indicator = new Indicator<int>();

        public override object GetIndicator() => indicator;
    }
}