using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class LettersInput : MonoBehaviour
{
    [SerializeField] private Text textDisplay;

    [SerializeField] private string press_button;

    private void Start()
    {
        textDisplay.color = Color.gray;
        textDisplay.text = "Enter Code";
    }

    public void SubmitButton()
    {
        SceneManager.LoadScene(1);
    }

    public void On_Click_button()
    {
        if (textDisplay.text == "Enter Code")
        {
            textDisplay.text = null;

            textDisplay.color = Color.black;

            textDisplay.text += press_button;
        }

        else
        {
            textDisplay.color = Color.black;

            textDisplay.text += press_button;
        }
    }
}
