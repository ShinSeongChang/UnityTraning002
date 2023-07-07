using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{  
    public GameObject gameoverText;
    public Text scoreText;
    public Text recordText;

    public float surviveTime;
    public bool isGameover;

    // Start is called before the first frame update
    void Start()
    {
        surviveTime = 0;
        isGameover = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(!isGameover)
        {
            surviveTime += Time.deltaTime * 10;
            scoreText.text = "Score : " + (int)surviveTime;

            float bestScore = PlayerPrefs.GetFloat("BestScore");

            if (surviveTime > bestScore)
            {
                bestScore = surviveTime;
                PlayerPrefs.SetFloat("BestScore", bestScore);
            }

            recordText.text = "Best Score : " + (int)bestScore;
        }
        else
        {
            if(Input.GetKeyDown(KeyCode.R) == true)
            {
                SceneManager.LoadScene("MainPlay");
            }
        }
    }

    public void EndGame()
    {
        isGameover = true;

        gameoverText.SetActive(true);        

    }
}
