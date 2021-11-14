using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
{
    // Start is called before the first frame update
    public void StartGame()
    {
        // load next scene (first scene) (skip over game over screen)
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }

    public void StartGameFromTutorial()
    {
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

    public void RestartGame()
    {
        // Go back to first level (Scene 3)
        SceneManager.LoadScene(5);
    }


}
