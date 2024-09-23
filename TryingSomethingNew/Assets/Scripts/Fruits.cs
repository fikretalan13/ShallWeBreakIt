using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruits : MonoBehaviour
{
public float fruitsSpeed=3;
    void Update()
    {
        transform.Translate(Vector2.down*Time.deltaTime*(fruitsSpeed+GameManager.instance.speedUp));
    }
}
