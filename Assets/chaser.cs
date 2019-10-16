using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chaser : MonoBehaviour
{
    public Transform targetTransform; // drag the player cube into this field in unity editor to get the player transform data
    public float moveSpeed = 7;
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 displacementFromTarget = targetTransform.position - transform.position;
        Vector3 directionToTarget = displacementFromTarget.normalized;
        Vector3 velocity = directionToTarget * moveSpeed;

        float distanceToTarget = displacementFromTarget.magnitude;
        if (distanceToTarget > 1.5)
        {
            transform.Translate(velocity * Time.deltaTime);
        }
    }
}
