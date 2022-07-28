using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RectangleAnimations : MonoBehaviour
{
    [SerializeField] private Animator animator;


    private void Update()
    {
        ButtonDown();
    }
  
    private void ButtonDown()
    {
        if (Input.GetKeyDown(KeyCode.Y))
        {
            Reset();

            AnimatorSetBool("ButtonY", true);
        }


        if (Input.GetKeyDown(KeyCode.B))
        {
            Reset();

            AnimatorSetBool("ButtonB", true);
        }
        

        if (Input.GetKeyDown(KeyCode.R))
        {
            Reset();

            AnimatorSetBool("ButtonR", true);
        }

        if (Input.GetKeyDown(KeyCode.G))
        {
            Reset();

            AnimatorSetBool("ButtonG", true);
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            Reset();
        }
    }

    //TODO Make more slow Reset
    private void Reset()
    {
        AnimatorSetBool("ButtonB", false);

        AnimatorSetBool("ButtonY", false);

        AnimatorSetBool("ButtonR", false);

        AnimatorSetBool("ButtonG", false);
    }

    private void AnimatorSetBool(string button, bool trueFalse)
    {
        animator.SetBool(button, trueFalse);
    }

}
