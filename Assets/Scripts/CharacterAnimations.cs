using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimations : MonoBehaviour
{
    [SerializeField] private Transform characterTransform;

    [SerializeField] private Animator characterAnimator;

    [SerializeField] private float newLossyScaleX;

    [SerializeField] private float newLossyScaleY;

    // Just to show another way

    //void Start()
    //{
    //    characterTransform = GetComponent<Transform>();

    //    characterAnimator = GetComponent<Animator>();
    //}

    private void Update()
    {
        CharacterTransform();

        KeyDown();
    }

    //For now doesen't work
    public void CharacterTransform()
    {
        newLossyScaleX = characterTransform.lossyScale.x;

        newLossyScaleY = characterTransform.lossyScale.y;


        if (newLossyScaleX > newLossyScaleY)

            newLossyScaleX = newLossyScaleY;

        else

            newLossyScaleY = newLossyScaleX;
    }

    private void KeyDown()
    {
        if (Input.GetKeyDown(KeyCode.Y) || Input.GetKeyDown(KeyCode.G) || Input.GetKeyDown(KeyCode.R) || Input.GetKeyDown(KeyCode.B))
        {
            CharacterAnimatorSetBool(false);

            CharacterAnimatorSetBool(true);
        }
        if (Input.GetKeyUp(KeyCode.Y) || Input.GetKeyUp(KeyCode.G) || Input.GetKeyUp(KeyCode.R) || Input.GetKeyUp(KeyCode.B) || Input.GetKeyDown(KeyCode.Q))
            
            CharacterAnimatorSetBool(false);
    }

    private void CharacterAnimatorSetBool(bool trueFalse)
    {
        string button = "KeyDown";

        characterAnimator.SetBool(button, trueFalse);
    }
}

