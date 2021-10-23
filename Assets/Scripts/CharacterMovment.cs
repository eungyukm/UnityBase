using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovment : MonoBehaviour
{
    public Animator animator;
    float speed = 8f;
    float turnSpeed = 60f;

    private CharaterInput characterInput;
    public CharacterController controller;

    public float turnSmoothTime = 0.1f;
    private float turnSmoothVelocity;

    public Transform cam;

    // Start is called before the first frame update
    void Start()
    {
        characterInput = GetComponent<CharaterInput>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move()
    {
        // 방향
        Vector3 direction = new Vector3(characterInput.horizontalInput, 0f, characterInput.verticalInput).normalized;

        if (direction.magnitude >= 0.1f)
        {
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);

            Vector3 moveDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
            controller.Move(direction * speed * Time.deltaTime);
            animator.SetBool("IsWalk", true);
        }
        else
        {
            animator.SetBool("IsWalk", false);
        }
    }
}