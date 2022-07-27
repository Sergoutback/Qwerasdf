using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using DG.Tweening;
public class AnimationsStart : MonoBehaviour
{
    [SerializeField] private GameObject rectangle;

    //[SerializeField] private string buttonValue;

    [SerializeField] private Animation animationBig;

    public void PressButtonY()
    {
        if (Input.GetKey("Y"))
        {
            animationBig = GetComponent<Animation>();

            animationBig.Play("BigRectangleAnimation");
        }

    }


}
