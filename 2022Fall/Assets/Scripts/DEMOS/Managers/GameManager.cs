using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    bool tester = false;
    public static bool gamePaused;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);

        //StartCoroutine(DelayedHello(1f));
        InvokeRepeating("SaySomething", 3f, 2.5f);

        gamePaused = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            tester = true;
        }
    }

    #region Pausing
    public void PauseGame()
    {
        Time.timeScale = 0f;
        gamePaused = true;
    }

    public void UnpauseGame()
    {
        Time.timeScale = 1f;
        gamePaused = false;
    }


    #endregion

    void SaySomething()
    {
        Debug.Log(":)");
    }

    IEnumerator DelayedHello(float waitTime)
    {
        Debug.Log("...");

        while(tester == false)
        {
            yield return new WaitForSeconds(waitTime);
            Debug.Log("Hello");
        }
    }

    #region Fading
    public void Fade(SpriteRenderer sr)
    {
        StartCoroutine(FadeTime(sr));
    }


    IEnumerator FadeTime(SpriteRenderer sr)
    {
        Color c = sr.material.color;
        for (float alpha = 1f; alpha >= 0; alpha -= 0.1f)
        {
            c.a = alpha;
            sr.material.color = c;
            yield return null;
        }
    }

    #endregion
}
