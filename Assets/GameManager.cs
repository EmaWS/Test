using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int score;
    public Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RestartScene()
    {
        SceneManager.LoadScene("Livello_1");
    }
    public void AddScore()
    {
        score++;
        Debug.Log(score);
        scoreText.text = score.ToString();
    }
}
