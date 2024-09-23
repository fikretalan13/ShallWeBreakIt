using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float playerSpeed;
    Rigidbody2D rb;

    [SerializeField] GameObject axe;
    [SerializeField] Transform axeOutPos;

    public float throwDelay = .1f;  // Fırlatmalar arasındaki gecikme süresi
    private float lastThrowTime;  // Son fırlatma zamanı

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) && Time.time >= lastThrowTime + throwDelay)
        {
            Instantiate(axe, axeOutPos.position, Quaternion.identity);
            lastThrowTime = Time.time;
        }
    }
    private void FixedUpdate()
    {
        Movement();
    }

    void Movement()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(horizontalInput * playerSpeed, rb.velocity.y);
    }
}
