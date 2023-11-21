using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor.Events;
using UnityEngine.Events;

public class caduta : MonoBehaviour
{
    [SerializeField]
    public Rigidbody2D rb;
    [SerializeField]
    private float jumpHight;
    bool onGround;

    public UnityEvent onGameOver;
    
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A) && onGround)
        {
            Jump();
        }
    }
    void Jump()
    {
        //velocità = direzione verticale * radice di >> 2 volte l'altezza del salto desiderata * |gravità| * scala gravità (in questo caso 1)
        rb.velocity = Vector2.up * Mathf.Sqrt(2f * jumpHight * Mathf.Abs(Physics2D.gravity.y) * rb.gravityScale);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
            {
                onGameOver.Invoke();
            }
        onGround = true;
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        onGround = false;  
    }

}
