﻿using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float speed = 20f;
    [SerializeField] private short damage = 5;
    [SerializeField] private Rigidbody rb;
    private void Start()
    {
        rb.velocity = transform.right * speed;
    }

    private void OnTriggerEnter(Collider other)
    {
        Enemy enemy = other.GetComponent<Enemy>();
        PlayerController player = other.GetComponent<PlayerController>();
        if (enemy != null)
        {
            enemy.TakeDamage(damage);
            Destroy(gameObject);
        }
        if (player != null)
        {
            player.TakeDamage(damage);
            Destroy(gameObject);
        }
        Destroy(gameObject, 2);
    }
}