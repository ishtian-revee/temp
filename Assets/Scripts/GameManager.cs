using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public float restartDelay; // This variable stores the value of the amount of time to restart the new level
    public GameObject completeLevelUi;  // A refference to the UI game object for completing the level
    public GameObject startLevelUi;     // A refference to the UI game object for starting the level
    public GameObject gameOverUi;   // A refference to the UI game object for game over
    public Score xy;    // A referrence to the score(distance travelled) value
    public Text dv;
    public string diamond;
    
    public UpdateScore upds;
    public GetPreviousScore ps;
    public GetScoreData gsd;
    public int id;
    public int score;
    public int previousScore;
    public int diamondValue;

    // Calls this method when the player enter the 'start' trigger cube
    public void StartLevel()
    {
        // Activating the start level UI
        startLevelUi.SetActive(true);
    }

    // This method calls whenever the game is over
    public void GameOver()
    {
        // Activating the game over UI
        gameOverUi.SetActive(true);

        diamond = dv.text;
        int.TryParse(diamond, out diamondValue);

        score = (int)xy.score;
       
        id = gsd.HsCount();      // Last index of player of database
        
        ps.GetPrevScore(id);
        previousScore = ps.prevScore;

        if (score > previousScore)
        {
            upds.UpdateData("HighScores", "PlayerID", id, "Score", score);
            upds.UpdateData("HighScores", "PlayerID", id, "Diamonds", diamondValue);
            previousScore = score;
            Debug.Log("Success QUery Update");
        }
    }

    // The method restarts the level
    public void Restart()
    {
        // Load the active scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    // Calls this method when the player enter the 'end' trigger cube
    public void CompleteLevel()
    {
        // Activating the complete level UI
        completeLevelUi.SetActive(true);

        // Disabling player movement
        FindObjectOfType<PlayerMovement>().enabled = false;

        diamond = dv.text;
        int.TryParse(diamond, out diamondValue);
      
        score = (int)xy.score;
        id = upds.x;
        upds.UpdateData("HighScores", "PlayerID", id, "Score", score);
        upds.UpdateData("HighScores", "PlayerID", id, "Diamonds", diamondValue);
    }
}
