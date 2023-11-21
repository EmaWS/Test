using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ObstacleMovement : MonoBehaviour
{
    public float _obstacleSpeed = 1.0f;
    public UnityEvent OnScore;
    GameManager manager;
    void Start()
    {
        manager = GameObject.FindGameObjectWithTag("Manager").GetComponent<GameManager>();
    }
   
    void Update()
    {
        transform.position += _obstacleSpeed * Time.deltaTime * Vector3.left;       
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        OnScore.Invoke();
    }

}
