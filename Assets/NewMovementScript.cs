
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;

    private Rigidbody2D rb;
    private Vector2 movement;

    public Sprite playa_normal;
    public Sprite playa_sad;
    public Transform rainmanaudio;
    public float distance = 21f;

    private SpriteRenderer spriteRenderer;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }


    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");


        float currentDistance = Vector2.Distance(transform.position, rainmanaudio.position);

        if (currentDistance > distance)
        {
            spriteRenderer.sprite = playa_sad;
        }
        else
        {
            spriteRenderer.sprite = playa_normal;
        }
    }


    void FixedUpdate()
    {
        rb.linearVelocity = movement.normalized * speed;
    }
}
