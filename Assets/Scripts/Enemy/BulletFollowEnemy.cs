using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletFollowEnemy : MonoBehaviour
{
    Rigidbody rb;

    public float speed = 0.02f;

    private Transform target;

    //private float moveSpeedFollow = 1f;  
    public float rotateSpeed = 200f;


    public float MoveSpeed5 = 1f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

        target = GameObject.FindGameObjectWithTag("Player").transform;

    }

    void Update()
    {

        Vector3 direction = (Vector3)target.position - rb.position;

        direction.Normalize();

        Vector3 rotateAmount = Vector3.Cross(direction, transform.forward);

        rb.angularVelocity = -rotateAmount * rotateSpeed;

        rb.velocity = transform.forward * speed;

    }


}