using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class RinoEnemy : MonoBehaviour
{
    public float speed;
    public Transform target;
    public float minimumDistance;
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
        if (Vector2.Distance(transform.position, target.position) < minimumDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, new Vector2(target.gameObject.transform.position.x, transform.position.y), (speed * Time.deltaTime) * 1.5f);
            if (target.position.x < transform.position.x)
            {
                _renderer.flipX = false;
            }
            else
            {
                _renderer.flipX = true;
            }
        }
        else
        {
            if (transform.position != patrolPoints[currentPointIndex].position)
            {
                transform.position = Vector2.MoveTowards(transform.position, patrolPoints[currentPointIndex].position, speed * Time.deltaTime);
                animator.SetBool("moving", true);
                if (patrolPoints[currentPointIndex].position.x < transform.position.x)
                {
                    _renderer.flipX = false;
                }
                else
                {
                    _renderer.flipX = true;
                }
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
