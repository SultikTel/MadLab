using System;
using UnityEngine;

namespace MadLab.Gameplay
{
    public class DestinyHavingObjects : MonoBehaviour
    {
        [SerializeField] private Collider2D _destinyZone;

        public event Action OnDestinyReached; 

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision == _destinyZone)
            {
                OnDestinyReached?.Invoke();
            }
        }
    }
}