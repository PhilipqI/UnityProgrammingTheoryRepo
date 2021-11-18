using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float jumpForce = 10;
    [SerializeField] private float speed = 1.0f;
    [SerializeField] private Vector2 startPosition = new Vector2(-4, 0);

    private LifeManager lifeManager;
    private Rigidbody2D playerRb;
    private float horizontalInput;
    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
        lifeManager = GameObject.FindObjectOfType<LifeManager>();
        gameManager = GameObject.FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if(gameManager.IsGameActive)
        {
            horizontalInput = Input.GetAxis("Horizontal");
            transform.Translate(Vector2.right * Time.deltaTime * speed * horizontalInput);

            if (Input.GetKeyDown(KeyCode.Space))
            {
                playerRb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            }
        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag(Constants.TAG_ENEMY))
        {
            lifeManager.ReduceLives();
            ResetPlayer();
        }
        else if (collision.gameObject.CompareTag(Constants.TAG_GOAL))
        {
            Debug.Log("Finish");
        }

    }

    private void ResetPlayer()
    {
        transform.position = startPosition;
    }
}
