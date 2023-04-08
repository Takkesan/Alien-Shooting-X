using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    const int SPEED = 5;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveWithKeyBordPlayer();
    }
    
    private void MoveWithKeyBordPlayer()
    {
        // キーボードの入力を取得する
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        
        //入力に基づいて移動させる
        transform.Translate(Vector3.right * horizontalInput * SPEED * Time.deltaTime);
        transform.Translate(Vector3.up * verticalInput * SPEED * Time.deltaTime);
    }
}
