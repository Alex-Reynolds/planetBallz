using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
{
    // Start is called before the first frame update
    public void StartGame()
    {
        // load next scene (first scene)
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    // quits game
    public void QuitGame()
    {
        // Unity does not actually quit the app when you test the game,
        // so below debug tells you to make sure when it quits
        Debug.Log("QUIT");
        Application.Quit();
    }
}
