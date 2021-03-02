using Gameplay;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Weapons.Projectiles
{
    public class Projectile : MonoBehaviour
    {
        [SerializeField] private float projectileSpeed;
        [SerializeField] private float maxLifetime = 3f;
        [SerializeField] private float damage = 1f;
        [SerializeField] private LayerMask projectileLayer;

        private bool hasBeenFired;
        private Vector3 fireDirection;
        private float currentLifetime;

        public void Fire(Vector3 direction)
        {
            hasBeenFired = true;
            fireDirection = direction;
        }

        private void Update()
        {
            if (hasBeenFired)
            {
                bool queueForDestroy = false;
                currentLifetime += Time.deltaTime;

                if (Physics.Raycast(new Ray(transform.position, fireDirection), out var hit, projectileSpeed * Time.deltaTime, ~projectileLayer))
                {
                    var damageable = hit.transform.GetComponent<Damageable>();
                    if (damageable != null)
                    {
                        damageable.TakeDamage(damage);
                    }

                    queueForDestroy = true;
                }
                else
                {
                    transform.position += fireDirection * Time.deltaTime * projectileSpeed;
                }

                if (queueForDestroy || currentLifetime >= maxLifetime)
                {
                    Destroy(gameObject);
                }
            }
        }
    }
}
