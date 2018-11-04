using UnityEngine;

public class StartTrigger : MonoBehaviour {

    // The method is called whenever a trigger happens
    void OnTriggerEnter()
    {
        // Calls the method from the gamemanager
        FindObjectOfType<GameManager>().StartLevel();
    }
}
