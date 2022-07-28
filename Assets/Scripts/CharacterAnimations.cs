using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimations : MonoBehaviour
{
    [SerializeField] private Transform characterTransform;

    [SerializeField] private Animator characterAnimator;


    void Start()
    {
        //characterTransform = GetComponent<Transform>();

        //characterAnimator = GetComponent<Animator>();
    }

    void Update()
    {
        CharacterTransform();

        KeyDown();
    }

    void CharacterTransform()
    {
        float newLocalScaleX = characterTransform.localScale.x;

        float newLocalScaleY = characterTransform.localScale.y;


        if (newLocalScaleX > newLocalScaleY)

            newLocalScaleX = newLocalScaleY;

        else

            newLocalScaleY = newLocalScaleX;
    }

    private void KeyDown()
    {
        if (Input.GetKeyDown(KeyCode.Y) || Input.GetKeyDown(KeyCode.G) || Input.GetKeyDown(KeyCode.R) || Input.GetKeyDown(KeyCode.B))
        {
            characterAnimator.SetBool(name: "KeyDown", value: false);

            characterAnimator.SetBool(name: "KeyDown", value: true);
        }
        if (Input.GetKeyUp(KeyCode.Y) || Input.GetKeyUp(KeyCode.G) || Input.GetKeyUp(KeyCode.R) || Input.GetKeyUp(KeyCode.B) || Input.GetKeyDown(KeyCode.Q))

            characterAnimator.SetBool(name: "KeyDown", value: false);
    }
}

