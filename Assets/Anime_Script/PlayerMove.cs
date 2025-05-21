using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    private Rigidbody2D rb;
    private Animator animator;
    private Vector2 PlyerMove;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        PlyerMove.x = Input.GetAxisRaw("Horizontal");
        PlyerMove.y = Input.GetAxisRaw("Vertical");

        //�ϴ� ���� �̵��� �ִϸ��̼� ���� 
        animator.SetFloat("MoveSpeed", Mathf.Abs(PlyerMove.x));
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + PlyerMove * moveSpeed * Time.fixedDeltaTime);
    }
}

