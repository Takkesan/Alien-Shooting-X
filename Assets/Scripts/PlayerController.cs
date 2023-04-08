using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    const int SPEED = 5;
    
    ShotController shotController_;
    
    // Start is called before the first frame update
    void Start()
    {
        shotController_ = GetComponent<ShotController>();
    }

    // Update is called once per frame
    void Update()
    {
        MoveWithKeyBordPlayer();

        if (Input.GetButtonDown("Shot"))
        {
            shotController_.Shot(transform.position);
        }
    }
    
    private void MoveWithKeyBordPlayer()
    {
        // キーボードの入力を取得する
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        
        //入力に基づいて移動させる
        float x = transform.position.x + horizontalInput * SPEED * Time.deltaTime;
        float y = transform.position.y + verticalInput * SPEED * Time.deltaTime;
        // 画面外に出ないように座標を加工
        x = Mathf.Clamp(x, -9.75f, 9.75f);
        y = Mathf.Clamp(y, -4.08f, 4.08f);
        
        transform.position = new Vector2(x, y);
    }
}
