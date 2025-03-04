using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MadLab.Effects
{
    public class EffectApplyableObject : MonoBehaviour
    {
        public Rigidbody2D Rigidbody { get; private set; }
        public Collider2D Collider { get; private set; }
        private List<Effect> effects;

        private void Start()
        {
            Rigidbody = GetComponent<Rigidbody2D>();
        }

        public void StartGame()
        {
            foreach (Effect effect in effects)
            {
                StartCoroutine(effect.Apply(this));
            }
        }
    }
}