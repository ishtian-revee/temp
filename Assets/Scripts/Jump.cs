using UnityEngine;

public class Jump : MonoBehaviour {

    public Rigidbody player;            // A refference to the player rigidbody
    public Vector3 platformPosition;    // A variable to store platform position
    public float jumpForce;             // Stores the value of force on y axis of the player
	
	// Update is called once per frame
    void Update()
    {
        // Checking the position of the player
        if ((player.position.z >= this.transform.position.z + 2f) && (player.position.z <= this.transform.position.z + 3f))
        {
            // Setting new platform position after collision
            platformPosition.z = this.transform.position.z;
            platformPosition.x = this.transform.position.x;
            platformPosition.y = this.transform.position.y + 0.5f;
            // Setting the platform position
            transform.position = platformPosition;
        }
    }

    // Detects any collision
    void OnCollisionEnter(Collision collisionInfo)
    {
        // Checking the collision information of player tag
        if (collisionInfo.collider.tag == "Player")
        {
            //transform.position = platformPosition;
            player.AddForce(0, jumpForce, 0);
        }
    }
}
