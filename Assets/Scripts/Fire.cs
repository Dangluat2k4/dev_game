using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows;

public class Fire : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] float speedBullet = 0f;

    Player player;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Destroy(gameObject, 1f);

        // Tìm kiếm đối tượng Player trong scene và gán vào biến player
        player = FindObjectOfType<Player>();
    }

    void Update()
    {
        // Kiểm tra nếu player không tồn tại thì không thực hiện hành động bắn đạn
        if (player == null)
            return;

        // Lấy hướng vector từ vị trí của đạn đến vị trí của nhân vật
        Vector2 direction = (player.transform.position - transform.position).normalized;

        // Thiết lập vận tốc của đạn theo hướng mặt của nhân vật
        rb.velocity = direction * -speedBullet;
    }
}
