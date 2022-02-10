using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Componentes que necesita el script para funcionar, esto ya los pone automáticamente
[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(SpriteRenderer))]
public class Bullet : MonoBehaviour
{
    private Rigidbody2D rb;
    public float bulletSpeed;

    private SpriteRenderer sprite;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void SpawnBullet()
    {
        sprite.enabled = true;
        rb.AddForce(transform.up * bulletSpeed, ForceMode2D.Impulse);
    }
}
