using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;


public class LettersInput : MonoBehaviour
{
    [SerializeField] private Text textDisplay;

    [SerializeField] private string press_button;

    private void SubmitButton()
    {

    }

    public void On_Click_button()
    {
        textDisplay.text += press_button;
    }
}
