using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Serialization;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float speed_ = 5.0f;
    [SerializeField] private int damege_ = 10;
    
    void Update()
    { 
        transform.Translate(Vector3.right * speed_ * Time.deltaTime);
    }
    
    void OnTriggerEnter2D(Collider2D other)
    {
        Health otherHealth = other.gameObject.GetComponent<Health>();
        if (otherHealth != null)
        {
            otherHealth.Damege(damege_);
            if (otherHealth.getHealth <= 0)
            {
                gameObject.SetActive(false);
            }
        }
    }

    /// <summary>
    /// 画面外に出たら、オブジェクトを非アクティブにする
    /// 非アクティブになったオブジェクトはオブジェクトプールによって再利用される
    /// </summary>
    void OnBecameInvisible()
    {
        gameObject.SetActive(false);
    }
}
