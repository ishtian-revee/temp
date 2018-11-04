using UnityEngine;

public class PlayerCollision : MonoBehaviour {

    // This method is called when the player collide with an object
    void OnCollisionEnter(Collision collisionInfo)  // Get the information about the collision and call it 'collisionInfo'
    {
        // Checking if the player collide with has a tag called 'Obstackle'
        if (collisionInfo.collider.tag == "Obstacle")
        {   
            // making the player movement to false
            GetComponent<PlayerMovement>().enabled = false;

            // Calls the game over method from the gamemanager
            FindObjectOfType<GameManager>().GameOver();
        }
    }
}
