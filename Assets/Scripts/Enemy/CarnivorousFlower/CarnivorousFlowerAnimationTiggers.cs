using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarnivorousFlowerAnimationTiggers : MonoBehaviour
{
    public Animator animator; // Tham chiếu tới Animator component của hoa
    
    void OnTriggerEnter2D(Collider2D other)
    {
       // Kiểm tra nếu player gần hoa thì tấn công
        if (other.CompareTag("Player"))
        {
            // Kích hoạt animation tấn công của hoa
            animator.SetTrigger("Attack");
            Debug.Log("======== Tấn Công ======");
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        // Kiểm tra nếu player ra khỏi vùng va chạm của hoa
        if (other.CompareTag("Player"))
        {
            // Đặt lại hoa về trạng thái cảnh giới
            animator.SetTrigger("Idle"); // về trạng thái cảnh giới
            Debug.Log("======== Chờ tấn công ======");
        }
    }
  
}
