using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using TMPro;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rd2D;
    public Animator animator;
    [SerializeField] private SpriteRenderer SR;
    float horizontalMove = 0f;
    float runSpeed = 4f;
    private Animator _animator;
    private SpriteRenderer _renderer;
    private Canvas doodMenu;
    private Canvas winMenu;
    private float moveSpeed = 1.5f;
    private float jumpForce = 45f;
    bool isJumping = false;
    public static float moveHorizontal;
    float moveVertical;
    public static bool einde;
    public static bool finishGehaald = false;
    public static int level;
    public GameObject EnemyDestroyEffect;



    // Start is called before the first frame update
    void Start()
    {
        rd2D = gameObject.GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
        _renderer = GetComponent<SpriteRenderer>();

        doodMenu = GameObject.Find("DoodMenu").GetComponent<Canvas>();
        doodMenu.enabled = false;
        einde = false;

        winMenu = GameObject.Find("WinMenu").GetComponent<Canvas>();
        winMenu.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        moveHorizontal = Input.GetAxisRaw("Horizontal");
        moveVertical = Input.GetAxisRaw("Vertical");


        //Animation
        horizontalMove = Input.GetAxis("Horizontal") * runSpeed;
        if (finishGehaald)
        {
            moveHorizontal = einde ? 0 : 1;
            horizontalMove = einde ? 0 : runSpeed;
        }
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

        if (moveHorizontal != 0f)
        {
            rd2D.AddForce(new Vector2(moveHorizontal * moveSpeed, 0f), ForceMode2D.Impulse);
        }

        if (moveVertical > 0f && !isJumping)
        {
            rd2D.AddForce(new Vector2(0f, moveVertical * jumpForce), ForceMode2D.Impulse);
        }

        if (moveHorizontal > 0)
        {
            _renderer.flipX = false;
        }
        else if (moveHorizontal < 0f)
        {
            _renderer.flipX = true;
        }
    
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Platform")
        {
            isJumping = false;
        }
        //dood gaan van enemy
        if (collision.gameObject.tag == "Enemy")
        {
            Instantiate(EnemyDestroyEffect, transform.position, Quaternion.identity);
            doodMenu.enabled = true;
            Destroy(gameObject);
            Debug.Log("hit");
        }
        if (collision.gameObject.tag == "Head") 
        {
            
            Destroy(collision.transform.parent.gameObject) ;
            Debug.Log("kaas");
        }

        if (collision.gameObject.tag == "Einde")
        {
            einde = true;
            winMenu.enabled = true;

        }

        if (collision.gameObject.tag == "Lijn")
        {
            finishGehaald = true;
        }
    }
        void OnTriggerExit2D(Collider2D collision)
    {
        //jumping
        if (collision.gameObject.tag == "Platform")
        {
            isJumping = true;
        }
       
    }
}
