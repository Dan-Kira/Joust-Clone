using UnityEngine;

public class TeleportPlayer : MonoBehaviour
{
    private Camera mainCamera;
    private float screenWidth;
    private float screenHeight;

    // Defina a margem onde o jogador vai atravessar
    public float teleportMargin = 1f;

    void Start()
    {
        mainCamera = Camera.main;
        screenWidth = mainCamera.orthographicSize * mainCamera.aspect;
        screenHeight = mainCamera.orthographicSize;
    }

    void Update()
    {
        // Checa se o jogador está fora dos limites horizontais
        if (transform.position.x > screenWidth + teleportMargin)
        {
            // Teletransporta o jogador para o lado esquerdo
            transform.position = new Vector2(-screenWidth - teleportMargin, transform.position.y);
        }
        else if (transform.position.x < -screenWidth - teleportMargin)
        {
            // Teletransporta o jogador para o lado direito
            transform.position = new Vector2(screenWidth + teleportMargin, transform.position.y);
        }

        // Checa se o jogador está fora dos limites verticais
        if (transform.position.y > screenHeight + teleportMargin)
        {
            // Teletransporta o jogador para o lado inferior
            transform.position = new Vector2(transform.position.x, -screenHeight - teleportMargin);
        }
        else if (transform.position.y < -screenHeight - teleportMargin)
        {
            // Teletransporta o jogador para o lado superior
            transform.position = new Vector2(transform.position.x, screenHeight + teleportMargin);
        }
    }
}
