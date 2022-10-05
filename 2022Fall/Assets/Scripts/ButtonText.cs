using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ButtonText : MonoBehaviour
{

    //public string firstName;
    public TMP_Text tmp;
    public TMP_InputField inputField;

    private void Start()
    {
        //tmp.SetText(firstName);
    }


    public void GetInput(string text)
    {
        string ourString = inputField.text;

        tmp.SetText(inputField.text);
    }


    public void SaySomething()
    {
        Debug.Log("Hello!");
    }

}
