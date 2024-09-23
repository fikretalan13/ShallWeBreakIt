using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogSpawner : MonoBehaviour
{
    [SerializeField] GameObject[] logs;
    [SerializeField] float repeatTime;

    private void Start() {
        InvokeRepeating("SpawnLogs",.5f,repeatTime);
    }
    void SpawnLogs()
    {
      int randomNumber = Random.Range(0,5);
      float posX=Random.Range(-2.375f,2.376f);
      Instantiate(logs[randomNumber],new Vector2(posX,transform.position.y),Quaternion.identity);
    }
}
