using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public Rigidbody projectile;

    public float ammoSpeed;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Rigidbody ammo = Instantiate(projectile, transform.position, transform.rotation);

            ammo.velocity = transform.forward * ammoSpeed;

        }
    }

}
