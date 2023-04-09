using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    private int health_ = 100;
    public void Damege(int damege)
    {
        health_ = Mathf.Max(0, health_ - damege);
    }
    
    public int getHealth => health_;
}
