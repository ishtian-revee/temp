using UnityEngine.SceneManagement;
using UnityEngine;

public class LeaderBoard : MonoBehaviour {

    public void BackToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
