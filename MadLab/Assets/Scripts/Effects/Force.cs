using MadLab.UI;
using System;
using UnityEngine;

namespace MadLab.Effects
{
    [CreateAssetMenu(menuName = "Effects/Force")]
    public class Force : Effect
    {
        [HideInInspector] public int strength;
        [HideInInspector] public Vector2 direction;
        public int maxStrength;
        public int minStrength;
        public Indicator<float> strengthIndicator;
        public Indicator<Vector2> directionIndicator;

        protected override void OnApply(EffectApplyableObject obj)
        {
            obj.Rigidbody.AddForce(direction.normalized * strength, ForceMode2D.Impulse);
        }
    }
}