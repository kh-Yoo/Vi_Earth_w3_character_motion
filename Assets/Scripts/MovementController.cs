using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    //1
    public float movementSpeed = 3.0f;

    //2
    Vector2 movement = new Vector2();

    Animator animator;

    string animationState = "AnimationState";
    Rigidbody2D rb2D;

    enum CharStates
    {
        walkEast = 1,
        walkSouth = 2,
        walkWest = 3,
        walkNorth = 4,
        idleSouth = 5
    }

    // Start is called before the first frame update
    private void Start()
    {
        //4
        animator = GetComponent<Animator>();
        rb2D = GetComponent<Rigidbody2D>();        
    }

    private void Update()
    {
        UpdateState();
    }

    //5
    void FixedUpdate()
    {
        MoveCharacter();
    }

    private void MoveCharacter()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        //7
        movement.Normalize();

        //8
        rb2D.velocity = movement * movementSpeed;
    }

    private void UpdateState()
    {
        if(movement.x > 0)
        {
            animator.SetInteger(animationState, (int)CharStates.walkEast);
        }
        else if(movement.x < 0)
        {
            animator.SetInteger(animationState, (int)CharStates.walkWest);
        }
        else if(movement.y > 0)
        {
            animator.SetInteger(animationState, (int)CharStates.walkNorth);
        }
        else if(movement.y < 0)
        {
            animator.SetInteger(animationState, (int)CharStates.walkSouth);
        }
        else
        {
            animator.SetInteger(animationState, (int)CharStates.idleSouth);
        }
    }
}
