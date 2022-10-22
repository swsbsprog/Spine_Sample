using Spine.Unity;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSkeletonAnimation : MonoBehaviour
{
    public enum StateType{None, idle, walking,}
    StateType State
    {
        get => state;
        set
        {
            if (state == value)
                return;
            skeletonAnimation.state.SetAnimation(0, value.ToString(), true);
            state = value;
        }
    }
    StateType state = StateType.None;
    SkeletonAnimation skeletonAnimation;
    void Start()
    {
        skeletonAnimation = GetComponent<SkeletonAnimation>();
    }

    void Update()
    {
        Vector2 move = Vector2.zero;

        //if (Input.GetKey(KeyCode.W)) move.y = 1;
        //if (Input.GetKey(KeyCode.S)) move.y = -1;
        if (Input.GetKey(KeyCode.A)) move.x = -1;
        if (Input.GetKey(KeyCode.D)) move.x = 1;

        if (move.x > 0)
            skeletonAnimation.skeleton.ScaleX = 1;
        else if (move.x < 0)
            skeletonAnimation.skeleton.ScaleX = -1;


        float speed = move.magnitude;
        State = speed > 0 ? StateType.walking : StateType.idle;

        transform.Translate(move * Time.deltaTime);
    }
}
