using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //if you are doing anything with scenes, be sure to include SceneManagement

public class SceneManagerScript: MonoBehaviour
{
    //You would have this manager sit on a GameManager GameObject that is not destroyed on load
    //if you do not have a script, such as a GameManager, already implemented, you can uncomment the following Start() to make sure this script exists between scenes
    //Since this script will exist between scenes, new scenes will not have a reference to this script, so make sure your GameManager GameObject has a unique tag other 
        //scripts that are referencing it can search for in their Start()!

    /*
    private void Start()
    {
        DontDestroyOnLoad(gameObject);
    }
    */

    //this is a very simple script that other scripts should call, such as a door collider or a GameManager.   
    public void ChangeScene(string sceneName) //You will feed in the name of the taget scene and this simple function will take you there!
    {
        SceneManager.LoadScene(sceneName);
    }

    
}
