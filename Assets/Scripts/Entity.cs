using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entity : MonoBehaviour
{
    // khai bao animation cua doi tuong
    public Animator anim { get; private set; }

    // trong luong cua doi tuong
    public Rigidbody2D rb { get; private set; }

    // collision info

    public Transform attackCheck;
    // attackCkeck diem kiem tra tan cong

    public float attackCkeckRadius;
    // attackCkeckRadius khoang cach tan cong

    [SerializeField] protected Transform groundCheck;
    // groundCheck pham vi duoi chan
    [SerializeField] protected float groundCheckDistance;
    // groundCheckDistance khoang cach kiem tra mat dat
    [SerializeField] protected Transform wallCheck;
    // wallCheck kiem tra tuong truoc mat
    [SerializeField] protected float wallCheckDistance;
    // wallCheckDistance khoang cach giua tuong
    [SerializeField] protected LayerMask whatIsGround;
    // loai mat dat



    // trai thai lat mat
    public int facingDir { get; private set; } = 1;
    // facingDir huong cua entity hien tai 
    protected bool facingRight = true;


    protected virtual void Start()
    {
        // khoi tao gia tri
        anim = GetComponentInChildren<Animator>();

        rb = GetComponent<Rigidbody2D>();
    }

    public virtual void Flip()
    {
        // dao nguoc trang thai 
        facingDir = facingDir * -1;
        // cap nhat trang thai cua facingRight true=> fasle and false=> true
        facingRight = !facingRight;
        // doi h??ng
        transform.Rotate(0, 180, 0);
    }


}
