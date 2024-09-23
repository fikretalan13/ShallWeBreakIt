using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    [SerializeField] GameObject settingsPanel;
    [SerializeField] GameObject playPanel;
    [SerializeField] Image buttonImg;

    bool isMuted;
    bool isClicked;

    private void Start()
    {
        if (!PlayerPrefs.HasKey("isMuted"))
        {
            PlayerPrefs.SetInt("isMuted", 0);
            Load();
        }
        else
        {
            Load();
        }
        AudioListener.pause = isMuted;
    }
    public void StartGame()
    {
        playPanel.SetActive(true);
        AudioManager.instance.PlaySound(3);
    }

    public void QuitGame()
    {
        Application.Quit();
        AudioManager.instance.PlaySound(3);
        print("Çıkış yapıldı!");
    }

    public void OpenSettingsPanel()
    {
        settingsPanel.SetActive(true);
        AudioManager.instance.PlaySound(3);
    }

    public void CloseSettingsPanel()
    {
        settingsPanel.SetActive(false);
        AudioManager.instance.PlaySound(3);
    }
    public void ClosePlayPanel()
    {
        playPanel.SetActive(false);
        AudioManager.instance.PlaySound(3);
    }

    public void FruitsGame()
    {
        SceneManager.LoadScene(1);
        AudioManager.instance.PlaySound(3);
    }
    public void BlockGame()
    {
        SceneManager.LoadScene(2);
        AudioManager.instance.PlaySound(3);
    }

    public void SoundManager()
    {
        AudioManager.instance.PlaySound(3);
        if (!isMuted)
        {
            isMuted = true;
            AudioListener.pause = true;
        }
        else
        {
            isMuted = false;
            AudioListener.pause = false;
        }
        Save();
    }

    void Load()
    {
        isMuted = PlayerPrefs.GetInt("isMuted") == 1;
    }

    void Save()
    {
        PlayerPrefs.SetInt("isMuted", isMuted ? 1 : 0);
    }
}
