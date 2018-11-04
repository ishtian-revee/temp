using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody rigidBody; // A referrence to the player rigidbody
    public float forwardForce;  // Stores the value of constant forward force
    public float sidewayForce;  // Stores the value of constant sideway force for left and right
    public float rotationalSpeed;   // Stroes the spinning value of the cube(player)
    public GameObject startLevelUi;     // A refference to the UI game object for starting the level
	
	// Update is called once per frame
	void FixedUpdate () 
    {
        // Adding force to the player for forward movement at each frames
        rigidBody.AddForce(0, 0, forwardForce * Time.deltaTime);

        // Making the cube(player) to spin
        transform.Rotate(Vector3.up, rotationalSpeed * Time.deltaTime);

        // Checks for movement in right
        if (Input.GetKey("d") || Input.GetKey(KeyCode.RightArrow))
        {
            // Adding force to right side of the player
            rigidBody.AddForce(sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        // Checks for movement in left
        if (Input.GetKey("a") || Input.GetKey(KeyCode.LeftArrow))
        {
            // Adding force to left side of the player 
            rigidBody.AddForce(-sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        // Checks if the player fall down from the platform
        if (rigidBody.position.y < -1f)
        {
            // Selecting the gameover scene from gamemanager
            rigidBody.useGravity = false;
            rigidBody.constraints = RigidbodyConstraints.FreezePosition;
            FindObjectOfType<GameManager>().GameOver();
        }

        // Disabling the start level splash ui after crossing 130 units
        if (rigidBody.position.z > 130f)
        {
            startLevelUi.SetActive(false);
        }
	}
}
