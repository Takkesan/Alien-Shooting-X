using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using UnityEngine;

public class ShotController : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab_;
    [SerializeField] private ObjectPoolManager bulletPool_;
    
    private GameObject bulletObject_;
    
    public void Shot(Vector2 createPosition)
    {
        bool resultGetObject_ = bulletPool_.TryGetAbleUseGameObjectFirst(out bulletObject_);
        if (resultGetObject_)
        {
            bulletObject_.transform.position = createPosition;
            bulletObject_.SetActive(true);
        }
        else
        {
            bulletObject_ = bulletPool_.AddNewObject();
            bulletObject_.transform.position = createPosition;
        }
    }
}
