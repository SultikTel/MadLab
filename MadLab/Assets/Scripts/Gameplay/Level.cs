using System;
using UnityEngine;

namespace MadLab.Gameplay
{
    public class Level : MonoBehaviour
    {
        public event Action<bool> OnLevelEnded;

        public void Restart()
        {
            Debug.Log("fad");
        }
    }
}
