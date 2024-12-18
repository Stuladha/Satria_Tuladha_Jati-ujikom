using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MovementPlayer : MonoBehaviour
{
    public Rigidbody rb;

    public float movementSpeed;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        float horizontalInput = Input.GetAxis("Horizontal");

  
        transform.position = transform.position + new Vector3(horizontalInput * movementSpeed * Time.deltaTime, 0);

        Debug.Log(transform.position);
    }




}
