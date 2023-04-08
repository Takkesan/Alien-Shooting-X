using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotController : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;
    
    public void Shot(Vector2 createPosition)
    {
        Instantiate(bulletPrefab, createPosition, Quaternion.identity);        
    }
}
