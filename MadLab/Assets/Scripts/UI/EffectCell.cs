using UnityEngine;
using UnityEngine.UI;

namespace MadLab.UI
{
    public class EffectCell : MonoBehaviour
    {
        [SerializeField] private Transform effectsContainer;
        [SerializeField] private Image effectImage;
        [SerializeField] private DelayIndicator delayIndicator;
    }
}