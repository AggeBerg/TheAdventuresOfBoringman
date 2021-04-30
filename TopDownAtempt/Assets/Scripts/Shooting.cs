using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform firePoint;
    public int damage = 50;
    public GameObject impactEffect;
    public Animator animator;


    public float bulletForce = 20f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.DrawLine(firePoint.position, hit.position);
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        RaycastHit2D hitInfo = Physics2D.Raycast(firePoint.position, firePoint.right);
        animator.SetTrigger("Shoot");

    if(hitInfo)
    {
        Debug.Log(hitInfo.transform.name);
        // Enemy enemy = hitInfo.transform.GetComponent<Enemy>();
        // if (enemy != null)
        // {
        //     enemy.TakeDamage(damage);
        //}
        Instantiate(impactEffect, hitInfo.point, transform.rotation);
    }

        // GameObject bullet = Instantiate(bulletPrefab, firePoint.position + firePoint.transform.forward * 5, firePoint.rotation);
        // Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        // rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
    }
}
