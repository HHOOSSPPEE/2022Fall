using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class StoryManager : MonoBehaviour
{
    public string[] story = new string[5];
    private int _storyindex;
    public GameObject btn;

    public string[] story1 = new string[10];
    public string[] story2 = new string[10];
    public int whichStory;

    public TMP_InputField inputField;
    public Button resetBtn;

    public TMP_Text mainText;

    // Start is called before the first frame update
    void Start()
    {
        _storyindex = 0;
        resetBtn.enabled = false;
    }


    public void InputResponse()
    {
        if(inputField.text == "")
        {
            mainText.SetText("Please type an answer.");
        }
        else
        {

        }
    }

    public void NextLineofStory()
    {
         _storyindex++;

        if (_storyindex < story.Length)
        {
            mainText.SetText(story[_storyindex]);      
        }
        else
        {
            mainText.SetText("The End.");
            btn.SetActive(false);
            resetBtn.enabled = true;
        }
    }

    public void SkipStory(int skipAmount)
    {
        _storyindex = _storyindex + skipAmount;

        if (_storyindex < story.Length)
        {
            mainText.SetText(story[_storyindex]);   
        }
        else
        {
            mainText.SetText("The End.");
            btn.SetActive(false);
            resetBtn.enabled = true;
        }
    }

    public void GoBack()
    {
        _storyindex --;

        if (_storyindex >= 0)
        {
            mainText.SetText(story[_storyindex]);
        }
        else
        {
            _storyindex = 0;
            //disable back button
        }
    }

    public void RestartStory()
    {
        _storyindex = 0;
        btn.SetActive(true);
    }

}
