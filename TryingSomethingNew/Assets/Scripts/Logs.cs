using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Logs : MonoBehaviour
{
    Animator anim;
    int logsHealth = 2;
    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Axe"))
        {
            logsHealth--;
            Destroy(other.gameObject);
            if (logsHealth == 1)
            {
               anim.SetTrigger("Break");
               AudioManager.instance.PlaySound(1);
            }

            else if(logsHealth == 0){
                logsHealth=0;
                AudioManager.instance.PlaySound(2);
                Instantiate(EffectManager.instance.logEffect,transform.position,Quaternion.identity);
                GameManager.instance.PointUp(10);
                GameManager.instance.speedUp += 0.15f;
                Destroy(gameObject);
            }
        }
    }
}
