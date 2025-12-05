using UnityEngine;

public class TwoPlayersMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private string inputNameHorizontal;
    [SerializeField] private string inputNameVertical;

    private Rigidbody2D rb;
    private float inputHorizontal;
    private float inputVertical;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        inputHorizontal = Input.GetAxisRaw(inputNameHorizontal);
        inputVertical = Input.GetAxisRaw(inputNameVertical);
    }

    void FixedUpdate()
    {
        rb.linearVelocity = new Vector2(inputHorizontal * speed, inputVertical * speed).normalized;
    }

}
