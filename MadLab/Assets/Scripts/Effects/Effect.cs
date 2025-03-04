using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MadLab.Effects
{

    public abstract class Effect : ScriptableObject
    {
        [HideInInspector] public int delay;
        public int maxDelay = 10;
        public int minDelay = 0;
        public Indicator<int> delayIndicator;
        public List<IndicatorWrapper> indicators;

        public virtual IEnumerator Apply(EffectApplyableObject obj)
        {
            yield return new WaitForSeconds(delay);
            OnApply(obj);
        }

        protected abstract void OnApply(EffectApplyableObject obj);
    }
}