using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using VR;

namespace VR
{
    [Serializable]
    public class HapticsImpulse
    {
        [SerializeField] private int channel;
        [SerializeField] private float amplitude;
        [SerializeField] private float duration;

        public void Execute(HandInput hand)
        {
            InputController.Instance.SendHaptics(hand, channel, amplitude, duration);
        }
    }
}
