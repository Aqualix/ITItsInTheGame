using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rd2D;
    public Animator animator;
    float horizontalMove = 0f;
    float runSpeed = 4f;


    private float moveSpeed = 1.5f;
    private float jumpForce = 60f;
    bool isJumping = false;
    float moveHorizontal;
    float moveVertical;
    // Start is called before the first frame update
    void Start()
    {
        rd2D = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        moveHorizontal = Input.GetAxisRaw("Horizontal");
        moveVertical = Input.GetAxisRaw("Vertical");


        //Animation
        horizontalMove = Input.GetAxis("Horizontal") * runSpeed;

        if (!isJumping)
        {
            animator.SetBool("isJumping", false);
        }
        else 
        {
            animator.SetBool("isJumping", true);
        }

        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));
    }
    void FixedUpdate()
    {
        if (moveHorizontal > 0f || moveHorizontal < 0f)
        {
            rd2D.AddForce(new Vector2(moveHorizontal * moveSpeed, 0f), ForceMode2D.Impulse);
        } 

        if (moveVertical > 0f && !isJumping)
        {
            rd2D.AddForce(new Vector2(0f, moveVertical * jumpForce), ForceMode2D.Impulse);
        } 
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Platform")
        {
            isJumping = false;
        }
    }
        void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Platform")
        {
            isJumping = true;
        }
    }
}
