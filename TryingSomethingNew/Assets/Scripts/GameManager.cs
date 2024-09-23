using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    [SerializeField] TextMeshProUGUI pointText;
    [SerializeField] TextMeshProUGUI highScoreText;
    
    [SerializeField] TextMeshProUGUI gameOverPointValue;
    int point = 0;
     private int highScore = 0;

    public float speedUp;
    private void Awake()
    {
        if (instance == null)
            instance = this;
    }
    void Start()
    {
        pointText.text = point.ToString();
        highScore = PlayerPrefs.GetInt("HighScore", 0);
        highScoreText.text =highScore.ToString();
    }

    public void PointUp(int value)
    {
        point += value;
        pointText.text = point.ToString();

        if (point > highScore)
        {
            highScore = point;
            highScoreText.text =highScore.ToString();
            // Yeni en yüksek skoru PlayerPrefs'e kaydet
            PlayerPrefs.SetInt("HighScore", highScore);
            PlayerPrefs.Save(); // Değişiklikleri kaydet
        }
        gameOverPointValue.text=point.ToString();
    }
}
