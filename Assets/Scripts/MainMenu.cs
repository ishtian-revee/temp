using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    // This method is called whenever the New Game button clicked
    public void NewGame()
    {
        //  Loads the scene of level01
        SceneManager.LoadScene("EnterName");
    }

    // This method is called whenever the user select the exit game UI button
    public void QuitGame()
    {
        // Exits the application
        Application.Quit();
    }

    // This method is called whenever the Option button clicked
    public void OptionScreen()
    {
        SceneManager.LoadScene("OptionScreen");
    }

    // This method is called whenever the Leaderboard button clicked
    public void LeaderboardScreen()
    {
        SceneManager.LoadScene("HighScore");
    }
}
