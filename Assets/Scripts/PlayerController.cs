using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float jumpForce = 10f; // Zıplama gücü

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Platforma çarpınca zıplama
        if (collision.gameObject.tag == "Platform")
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
        }
    }
    public float moveSpeed = 5f; // Hareket hızı

void Update()
{
    // Sağ ve sol ok tuşlarıyla hareket
    float moveInput = Input.GetAxis("Horizontal");
    rb.linearVelocity = new Vector2(moveInput * moveSpeed, rb.linearVelocity.y);

    // Sınırlı ekran hareketi (ekran dışına çıkmayı engellemek için)
    float screenHalfWidth = Camera.main.orthographicSize * Screen.width / Screen.height;
    if (transform.position.x > screenHalfWidth)
    {
        transform.position = new Vector2(-screenHalfWidth, transform.position.y);
    }
    else if (transform.position.x < -screenHalfWidth)
    {
        transform.position = new Vector2(screenHalfWidth, transform.position.y);
    }
}

}