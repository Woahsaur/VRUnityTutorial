using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace VR.Grabbing.RangedGrabbing
{
    public class RangedGrabTarget : MonoBehaviour
    {
        [SerializeField] private Transform targetIndicator;
        [field: SerializeField] public Grabbable Grabbable { get; private set; }

        private void Start()
        {
            targetIndicator.gameObject.SetActive(false);
        }

        public void Target()
        {
            targetIndicator.gameObject.SetActive(true);
        }

        public void Untarget()
        {
            targetIndicator.gameObject.SetActive(false);
        }
    }
}
