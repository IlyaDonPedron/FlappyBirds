using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour
{
    public string playerTag = "Player";
    private float attractionForce = 10f;

    private Rigidbody2D rb;
    private Transform playerTransform;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        GameObject playerObject = GameObject.FindGameObjectWithTag(playerTag);

        if (playerObject != null)
        {
            playerTransform = playerObject.transform;
        }
    }

    private void FixedUpdate()
    {
        if (playerTransform != null)

        {
            Vector2 direction = playerTransform.position - transform.position;
            rb.AddForce(direction.normalized * attractionForce);
        }
    }
}
