using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float Speed_ = 5.0f;
    
    void Update()
    { 
        transform.Translate(Vector3.right * Speed_ * Time.deltaTime);
    }
}
