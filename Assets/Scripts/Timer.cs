using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float totalTime = 300f; // Total time in seconds (5 minutes)
    public string gameOverSceneName = "GameOver"; // Name of the scene to load when time runs out
    public Text timerText; // Reference to the Text UI element to display the remaining time

    private float timeRemaining;

    void Start()
    {
        timeRemaining = totalTime;
        UpdateTimerText();
    }

    void Update()
    {
        timeRemaining -= Time.deltaTime;
        if (timeRemaining <= 0f)
        {
            SceneManager.LoadScene(gameOverSceneName);
        }
        UpdateTimerText();
    }

    void UpdateTimerText()
    {
        int minutes = Mathf.FloorToInt(timeRemaining / 60f);
        int seconds = Mathf.FloorToInt(timeRemaining % 60f);
        string timeString = string.Format("{0:00}:{1:00}", minutes, seconds);
        timerText.text = "Time: " + timeString;
    }
}
