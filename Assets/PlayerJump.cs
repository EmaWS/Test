using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    public Rigidbody2D _player;   
    public float _fallSpeed;    

    private void Awake()
    {
        //_player = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _player.velocity = new Vector2(0, 10);

        }
    }


    void FixedUpdate()
    {
        if (transform.position.y >= 2)
        {
            _player.velocity = new Vector2(0,-1 * _fallSpeed);
        }

    }
}
