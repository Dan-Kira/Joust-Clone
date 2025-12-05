using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.UIElements;
//****Este codigo so tem a movimentacao 
//A partir da linha 36 temos a referencia do codigo de coleta de itens
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

//compara a tag coin e se o perosnagem encostar a moeda eh destroida 
//E tambem tem o contador
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

