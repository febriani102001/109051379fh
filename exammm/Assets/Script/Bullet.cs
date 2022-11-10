using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FH
{
    public class Bullet : MonoBehaviour
    {

        [SerializeField] private float speed = 10f;

        [Range(1, 10)]
        [SerializeField] private float lifeTime = 3f;

        private Rigidbody2D rb;

        private void Start()
        {
            rb = GetComponent<Rigidbody2D>();
            Destroy(gameObject, lifeTime);

        }

        private void FixedUpdate()
        {
            rb.velocity = transform.up * speed;

        }

        private void OnCollisionEnter2D(Collision2D collision)
        {

            if (collision.gameObject.TryGetComponent<Enemy>(out Enemy enemyComponent))
            {
                enemyComponent.TakeDamage(1);
            }

            Destroy(gameObject);

        }
    }
}

 


