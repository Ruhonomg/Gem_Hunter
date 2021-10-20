using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Slider timerSlider;
   public float gameTime;

    private bool stopTimer;

    public GameObject portal;
    public Transform portalTransform;


    public int chestCount;
    public int score;
    public Text score_Text;
    public GameObject gameOverBox;
    public GameObject victoryBox;
    
    void Start()
    {
        score_Text.text = "0";
        stopTimer = false;
        timerSlider.maxValue = gameTime;
        timerSlider.value = gameTime;

    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void AddPoint()
    {
        score++;
        if(score == chestCount)
        {
            Instantiate(portal, portalTransform);
        }
    }


    
    void Update()
    {
        float time = gameTime - Time.time;

        int minutes = Mathf.FloorToInt(time / 60);
        int seconds = Mathf.FloorToInt(time - minutes * 60f);

        if(time<= 0)
        {
            stopTimer = true;
            gameOverBox.SetActive(true);
        }

        if(stopTimer == false)
        {
            timerSlider.value = time;
            
        }
    }
}
