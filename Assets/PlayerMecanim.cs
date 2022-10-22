using Spine.Unity;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMecanim : MonoBehaviour
{
    Animator animator;
    SkeletonMecanim skeletonMecanim;

    public float walkSpeed = 2;
    public float runSpeed = 3.5f;
    void Start()
    {
        animator = GetComponent<Animator>();
        skeletonMecanim = GetComponent<SkeletonMecanim>();
    }
    void Update()
    {
        Vector2 move = Vector2.zero;

        if (Input.GetKey(KeyCode.W)) move.y = 1;
        if (Input.GetKey(KeyCode.S)) move.y = -1;
        if (Input.GetKey(KeyCode.A)) move.x = -1;
        if (Input.GetKey(KeyCode.D)) move.x = 1;

        if (move.x > 0)
            skeletonMecanim.skeleton.ScaleX = 1;
        else if(move.x < 0)
            skeletonMecanim.skeleton.ScaleX = -1;
        move.Normalize();
        float speed = move.magnitude * walkSpeed;
        bool run = Input.GetKey(KeyCode.LeftShift);
        if (run)
            speed *= runSpeed;

        animator.SetFloat("Speed", speed);
        transform.Translate(speed * Time.deltaTime * move);
    }
}
