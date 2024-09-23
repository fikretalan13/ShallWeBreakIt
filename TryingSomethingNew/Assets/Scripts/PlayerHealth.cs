using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public static PlayerHealth instance;
    private int maxHealth = 3;
    public int currentHealth;

    public bool gameOver;

    [SerializeField] Image[] healthIMG;
    [SerializeField] Sprite healthSprite;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    void Start()
    {
        gameOver = false;
        currentHealth = maxHealth;
    }
    public void TakenDamage()
    {
        currentHealth--;
        if (currentHealth == 2)
        {
            AudioManager.instance.PlaySound(5);
            healthIMG[2].sprite = healthSprite;
        }
        else if (currentHealth == 1)
        {
            AudioManager.instance.PlaySound(5);
            healthIMG[1].sprite = healthSprite;
            healthIMG[2].sprite = healthSprite;
        }
        else if (currentHealth == 0)
        {
            gameOver = true;
            AudioManager.instance.PlaySound(4);
            healthIMG[0].sprite = healthSprite;
            healthIMG[1].sprite = healthSprite;
            healthIMG[2].sprite = healthSprite;
            print("GameOver");
            UIManager.instance.OpenGameOverPanel();
            Time.timeScale = 0f;
        }


    }
}
