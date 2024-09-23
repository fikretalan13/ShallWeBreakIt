using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitDestory : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Apple"))
        {
            PlayerHealth.instance.TakenDamage();
            Destroy(other.gameObject);
        }
        else if (other.CompareTag("Tomato"))
        {
            PlayerHealth.instance.TakenDamage();
            Destroy(other.gameObject);
        }
        else if (other.CompareTag("Banana"))
        {
            PlayerHealth.instance.TakenDamage();
            Destroy(other.gameObject);
        }
        else if (other.CompareTag("Grabe"))
        {
            PlayerHealth.instance.TakenDamage();
            Destroy(other.gameObject);
        }
        else if (other.CompareTag("Orange"))
        {
            PlayerHealth.instance.TakenDamage();
            Destroy(other.gameObject);
        }
        else if (other.CompareTag("Pumkin"))
        {
            PlayerHealth.instance.TakenDamage();
            Destroy(other.gameObject);
        }
        else if (other.CompareTag("Watermelon"))
        {
            PlayerHealth.instance.TakenDamage();
            Destroy(other.gameObject);
        }
        else if (other.CompareTag("Pear"))
        {
            PlayerHealth.instance.TakenDamage();
            Destroy(other.gameObject);
        }
        else if (other.CompareTag("Logs"))
        {
            PlayerHealth.instance.TakenDamage();
            Destroy(other.gameObject);
        }
    }
}
