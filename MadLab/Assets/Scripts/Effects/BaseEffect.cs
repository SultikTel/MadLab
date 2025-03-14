using System.Collections.Generic;
using UnityEngine;

namespace Effects
{
    public abstract class BaseEffect : ScriptableObject
    {
        [SerializeField] private float minDelay = 0;
        [SerializeField] private float maxDelay = 10;
        private float delay;
        public abstract void AppearOnPanel();
    }
    public class Force : BaseEffect
    {
        public override void AppearOnPanel()
        {
            throw new System.NotImplementedException();
        }
    }
}