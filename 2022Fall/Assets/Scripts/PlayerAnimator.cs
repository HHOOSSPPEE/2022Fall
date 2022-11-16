using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    #region Animation Variables
    private Animator _animator;
    private string _currentState = " ";
    #endregion

    #region Animation States
    public string IDLE_FRONT;


    #endregion

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    //movementcode in update

    public void ChangeAnimationState(string newState)
    {
        if (_currentState == newState)
            return;

        _animator.Play(newState);

        _currentState = newState;
    }

    public void PlayJump()
    {
        _animator.Play(IDLE_FRONT);
    }

    public void TouchingWall()
    {

    }

}
