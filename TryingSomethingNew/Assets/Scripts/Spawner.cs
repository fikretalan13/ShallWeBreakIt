using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject[] fruits;

    private void Start() {
        InvokeRepeating("SpawnFruits",.5f,1f);
    }
    void SpawnFruits()
    {
      int randomNumber = Random.Range(0,8);
      float posX=Random.Range(-2.375f,2.376f);
      Instantiate(fruits[randomNumber],new Vector2(posX,transform.position.y),Quaternion.identity);
    }
}
