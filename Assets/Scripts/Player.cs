using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    Rigidbody rb;
    SpriteRenderer rbSprite;
    float horizontal;
    public float velocity;
    public float velocity2;
    [Header("SALTO")]
    [SerializeField]private float JumpForce;
    [SerializeField]private bool canJump;
    [SerializeField]private Transform origin;
    [SerializeField]private float distance;
    [SerializeField]private LayerMask LayerMask;
    [SerializeField]private Color withCollision = Color.red;
    [SerializeField]private Color withoutCollision = Color.green;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rbSprite = rb.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
    }
    private void FixedUpdate()
    {
        rb.linearVelocity=new Vector2 (horizontal* velocity,-velocity2);
        RaycastHit2D Hit = Physics2D.Raycast(origin.position,Vector2.down,distance,LayerMask);
        if (Hit.collider != null)
        {
            Debug.DrawRay(origin.position, Vector2.down * Hit.distance, withCollision);
        }
        else
        {
            Debug.DrawRay(origin.position, Vector2.down * distance, withoutCollision);
        }
    }
}
