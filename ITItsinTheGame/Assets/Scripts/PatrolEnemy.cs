using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrolEnemy : MonoBehaviour
{
    public float speed;
    public Transform[] patrolPoints;
    public float waitTime;
    int currentPointIndex;
    public Animator animator;
    private SpriteRenderer _renderer;
    

    bool once;

    private void Start()
    {
        _renderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        if (transform.position != patrolPoints[currentPointIndex].position)
        {
            transform.position = Vector2.MoveTowards(transform.position, patrolPoints[currentPointIndex].position, speed * Time.deltaTime);
            animator.SetBool("moving", true);
        }
        else
        {
            if (once == false)
            {
                once = true;
                StartCoroutine(Wait());
                animator.SetBool("moving", false);
                if (_renderer.flipX == true)
                {
                    _renderer.flipX = false;
                }
                else
                {
                    _renderer.flipX = true;
                }

            }
        }
    }
    IEnumerator Wait()
    {
        yield return new WaitForSeconds(waitTime);
        if (currentPointIndex + 1 < patrolPoints.Length)
        {
            currentPointIndex++;
        }
        else
        {
            currentPointIndex = 0;
        }
        once = false;


    }
   
}
