using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Gameplay
{
    public class Damageable : MonoBehaviour
    {
        [SerializeField] private float health;

        public void TakeDamage(float damage)
        {
            health -= damage;

            if (health <= 0f)
            {
                Destroy(gameObject);
            }
        }
    }
}
