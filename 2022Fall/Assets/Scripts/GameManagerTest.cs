using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerTest : MonoBehaviour
{
    public bool gamePaused;
    

    // Start is called before the first frame update
    void Start()
    {
        gamePaused = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(gamePaused == true)
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                Debug.Log("Pause variable");
            }
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            Debug.Log("No pause variable");
        }
    }

    public void PauseGame()
    {
        Time.timeScale = 0f;
        gamePaused = false;
    }

    public void UnpauseGame()
    {
        Time.timeScale = 1f;
        gamePaused = true;
    }
}
