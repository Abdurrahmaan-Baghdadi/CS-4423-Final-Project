using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationStateController : MonoBehaviour
{
    Animator animator;
    string curState = "RolosIdle";
    void Awake()
    {
        animator = GetComponent<Animator>();

    }

    public void ChangeAnimationState(string stateName, float speed = 1)
    {
        animator.speed = speed;
        if(stateName == curState)
        {
            return;
        }
        animator.Play(stateName);
        curState = stateName;
    }
}
