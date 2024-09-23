using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;
    [SerializeField] GameObject pausePanel;
    [SerializeField] GameObject gameOverPanel;
    int sceneIndex;
    private void Awake()
    {
        if (instance == null)
            instance = this;
    }
    private void Start()
    {
        pausePanel.SetActive(false);
        gameOverPanel.SetActive(false);
        sceneIndex = SceneManager.GetActiveScene().buildIndex;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pausePanel.SetActive(true);
            Time.timeScale = 0;
        }
    }

    public void BackToMenu()
    {
        AudioManager.instance.PlaySound(3);
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }

    public void ReStartGame()
    {
        AudioManager.instance.PlaySound(3);
        SceneManager.LoadScene(sceneIndex);
        Time.timeScale = 1;
    }

    public void ResumeGame()
    {
        AudioManager.instance.PlaySound(3);
        pausePanel.SetActive(false);
        Time.timeScale = 1;
    }
    public void OpenGameOverPanel()
    {
        gameOverPanel.SetActive(true);
    }
}
