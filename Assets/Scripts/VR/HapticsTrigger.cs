using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace VR
{
    public class HapticsTrigger : MonoBehaviour
    {
        [SerializeField] private HapticsImpulse impulse;

        public void TriggerHaptics(HandInput hand)
        {
            impulse.Execute(hand);
        }
    }
}
