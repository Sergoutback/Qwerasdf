using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using DG.Tweening;
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
        if (Input.GetKeyDown(KeyCode.Y))
        {
            animator.SetBool(name: "ButtonY", value: true);
        }

        if (Input.GetKeyUp(KeyCode.Y))
        {
            animator.SetBool(name: "ButtonY", value: false);
        }


        if (Input.GetKeyDown(KeyCode.B))
        {
            animator.SetBool(name: "ButtonB", value: true);
        }

        if (Input.GetKeyUp(KeyCode.B))
        {
            animator.SetBool(name: "ButtonB", value: false);
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            animator.SetBool(name: "ButtonR", value: true);
        }

        if (Input.GetKeyUp(KeyCode.R))
        {
            animator.SetBool(name: "ButtonR", value: false);
        }

        if (Input.GetKeyDown(KeyCode.G))
        {
            animator.SetBool(name: "ButtonG", value: true);
        }

        if (Input.GetKeyUp(KeyCode.G))
        {
            animator.SetBool(name: "ButtonG", value: false);
        }

    }


}
