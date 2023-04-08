using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private float speed_ = 5.0f;
    
    void Update()
    { 
        transform.Translate(Vector3.right * speed_ * Time.deltaTime);
    }
}
