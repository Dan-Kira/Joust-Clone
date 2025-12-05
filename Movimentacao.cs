using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.UIElements;

public class Movimentacao : MonoBehaviour
{
    public float moveSpeed = 5f;      // Velocidade
    public float jumpForce = 10f;     // Força do pulo
    private Rigidbody2D rb;           
    public CoinManager cm;
    void Start()
    {
        // referÊncia
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Movimentação esquerda direita
        float moveInput = Input.GetAxis("Horizontal"); 
        rb.linearVelocity = new Vector2(moveInput * moveSpeed, rb.linearVelocity.y);

        // Pulo
        if (Input.GetButtonDown("Jump")) // se o batoao selecionar
        {
            rb.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
        }
    
    
    
    
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        {
            if(other.gameObject.CompareTag("Coin"))
            {
             Destroy(other.gameObject);
             other.gameObject.SetActive(true);
             cm.coinCount++;
            
            
            }

        }





    }








}

