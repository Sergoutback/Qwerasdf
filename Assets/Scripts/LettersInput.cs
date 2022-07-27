using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class LettersInput : MonoBehaviour
{
    [SerializeField] private Text textDisplay;

    [SerializeField] private string press_button;

    public void SubmitButton()
    {
        SceneManager.LoadScene(1);
    }

    public void On_Click_button()
    {
        textDisplay.text += press_button;
    }
}
