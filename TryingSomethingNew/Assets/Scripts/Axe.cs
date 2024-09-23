using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;

public class Axe : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float rotationSpeed = 360f;

    void Update()
    {
        // Balta ileriye doğru gitsin
        transform.Translate(Vector2.up * moveSpeed * Time.deltaTime, Space.World);

        // Balta etrafında dönsün
        transform.Rotate(0, 0, rotationSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Apple"))
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
            AudioManager.instance.PlaySound(0);
            Instantiate(EffectManager.instance.fruitsEffects[0], transform.position, Quaternion.identity);
            GameManager.instance.PointUp(10);
            GameManager.instance.speedUp += 0.15f;
        }
        else if (other.CompareTag("Tomato"))
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
            AudioManager.instance.PlaySound(0);
            Instantiate(EffectManager.instance.fruitsEffects[6], transform.position, Quaternion.identity);
            GameManager.instance.PointUp(5);
            GameManager.instance.speedUp += 0.015f;
        }
        else if (other.CompareTag("Banana"))
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
            AudioManager.instance.PlaySound(0);
            Instantiate(EffectManager.instance.fruitsEffects[1], transform.position, Quaternion.identity);
            GameManager.instance.PointUp(5);
            GameManager.instance.speedUp += 0.015f;
        }
        else if (other.CompareTag("Grabe"))
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
            AudioManager.instance.PlaySound(0);
            Instantiate(EffectManager.instance.fruitsEffects[2], transform.position, Quaternion.identity);
            GameManager.instance.PointUp(15);
            GameManager.instance.speedUp += 0.015f;
        }
        else if (other.CompareTag("Orange"))
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
            AudioManager.instance.PlaySound(0);
            Instantiate(EffectManager.instance.fruitsEffects[3], transform.position, Quaternion.identity);
            GameManager.instance.PointUp(5);
            GameManager.instance.speedUp += 0.015f;
        }
        else if (other.CompareTag("Pumkin"))
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
            AudioManager.instance.PlaySound(0);
            Instantiate(EffectManager.instance.fruitsEffects[5], transform.position, Quaternion.identity);
            GameManager.instance.PointUp(20);
            GameManager.instance.speedUp += 0.015f;
        }
        else if (other.CompareTag("Watermelon"))
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
            AudioManager.instance.PlaySound(0);
            Instantiate(EffectManager.instance.fruitsEffects[7], transform.position, Quaternion.identity);
            GameManager.instance.PointUp(20);
            GameManager.instance.speedUp += 0.015f;
        }
        else if (other.CompareTag("Pear"))
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
            AudioManager.instance.PlaySound(0);
            Instantiate(EffectManager.instance.fruitsEffects[4], transform.position, Quaternion.identity);
            GameManager.instance.PointUp(15);
            GameManager.instance.speedUp += 0.015f;
        }
    }
}
