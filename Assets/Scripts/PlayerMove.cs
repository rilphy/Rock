using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMove : MonoBehaviour
{
    [Header("Movement Settings")]
    [SerializeField] private float moveSpeed = 5f;

    public Rigidbody2D rigidbody;
    public float moveInputX;


    void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    public void OnMove(InputValue value)
    {
        moveInputX = value.Get<Vector2>().x;
    }

    private void FixedUpdate()
    {
        rigidbody.linearVelocity = new Vector2(moveInputX * moveSpeed, rigidbody.linearVelocity.y);
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
