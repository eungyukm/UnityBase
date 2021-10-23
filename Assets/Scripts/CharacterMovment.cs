using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovment : MonoBehaviour
{
    public Animator animator;
    float speed = 8f;
    float turnSpeed = 60f;

    private CharaterInput characterInput;

    // Start is called before the first frame update
    void Start()
    {
        characterInput = GetComponent<CharaterInput>();
    }

    // Update is called once per frame
    void Update()
    {
        Rotate();
        Move();
    }

    private void Move()
    {
        if(characterInput.move != 0)
        {
            Vector3 moveVector = characterInput.move * Vector3.forward;
            transform.Translate(moveVector * speed * Time.deltaTime);
            animator.SetBool("IsWalk", true);
        }
        else
        {
            animator.SetBool("IsWalk", false);
        }
    }

    private void Rotate()
    {
        if(characterInput.rotate != 0)
        {
            Quaternion newRotation = Quaternion.Euler(0, characterInput.rotate * turnSpeed, 0);
            transform.rotation = Quaternion.Slerp(transform.rotation, transform.rotation * newRotation, Time.deltaTime);
        }
        else
        {

        }
    }
}