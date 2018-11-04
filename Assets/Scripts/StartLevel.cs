using UnityEngine;
using UnityEngine.SceneManagement;

public class StartLevel : MonoBehaviour
{
    // This method is called whenever the continue button from enter name scene is clicked
    public void ContinueToLevels()
    {
        SceneManager.LoadScene("LevelsScene");
    }

    // This method is called whenever the go back to main menu button is clicked
    public void BackToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    // This method is called whenever the level01 button is clicked
    public void LoadLevel1()
    {
        SceneManager.LoadScene("Level01");
    }

    // This method is called whenever the level02 button is clicked
    public void LoadLevel2()
    {
        SceneManager.LoadScene("Level02");
    }

    // This method is called whenever the level03 button is clicked
    public void LoadLevel3()
    {
        SceneManager.LoadScene("Level03");
    }

    // This method is called whenever the continue button at the end of each level is clicked
    public void LevelContinue()
    {
        SceneManager.LoadScene("LevelsScene");
    }
}
