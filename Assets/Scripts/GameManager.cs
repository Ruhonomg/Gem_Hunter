using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
   public Slider timerSlider;
   public float gameTime;

   public GameObject FinalDoor;

    private bool stopTimer;

    public int chestCount;
    public int score;
    public GameObject gameOverBox;
    public GameObject victoryBox;
    
    void Start()
    {
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
            FinalDoor.SetActive(false);
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
