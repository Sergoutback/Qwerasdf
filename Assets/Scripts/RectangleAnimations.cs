using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RectangleAnimations: MonoBehaviour
{
    //[SerializeField] private GameObject rectangle;

    [SerializeField] private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        ButtonDown();
    }

    //TODO Change to Object oriented
    //TODO Make more slow Reset
    private void ButtonDown()
    {
        if (Input.GetKeyDown(KeyCode.Y))
        {
            Reset();

            animator.SetBool(name: "ButtonY", value: true);
        }

        //if (Input.GetKeyUp(KeyCode.Y))
        //{
        //    animator.SetBool(name: "ButtonY", value: false);
        //}


        if (Input.GetKeyDown(KeyCode.B))
        {
            Reset();

            animator.SetBool(name: "ButtonB", value: true);
        }

        //if (Input.GetKeyUp(KeyCode.B))
        //{
        //    animator.SetBool(name: "ButtonB", value: false);
        //}

        if (Input.GetKeyDown(KeyCode.R))
        {
            Reset();

            animator.SetBool(name: "ButtonR", value: true);
        }

        //if (Input.GetKeyUp(KeyCode.R))
        //{
        //    animator.SetBool(name: "ButtonR", value: false);
        //}

        if (Input.GetKeyDown(KeyCode.G))
        {
            Reset();

            animator.SetBool(name: "ButtonG", value: true);
        }

        //if (Input.GetKeyUp(KeyCode.G))
        //{
        //    animator.SetBool(name: "ButtonG", value: false);
        //}

        if (Input.GetKeyDown(KeyCode.Q))
        {
            Reset();
        }


    }
    //TODO Change to Object oriented
    private void Reset()
    {
        animator.SetBool(name: "ButtonB", value: false);

        animator.SetBool(name: "ButtonY", value: false);

        animator.SetBool(name: "ButtonR", value: false);

        animator.SetBool(name: "ButtonG", value: false);

    }
}
