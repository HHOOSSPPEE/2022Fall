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

    public TMP_Text mainText;

    // Start is called before the first frame update
    void Start()
    {
        _storyindex = 0;
    }

    public void NextLineofStory()
    {
        if (_storyindex < story.Length)
        {
            mainText.SetText(story[_storyindex]);

            _storyindex++;
        }
        else
        {
            mainText.SetText("The End.");
            btn.SetActive(false);
        }
    }
}
