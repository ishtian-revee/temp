using UnityEngine;

public class FollowPlayer : MonoBehaviour {

    public Transform player;    // A reffernce to the player's transform
    public Vector3 offset;      // A variable to store offset position
	
	// Update is called once per frame
	void Update () 
    {
        // Setting the camera position to behind the player forever
        transform.position = player.position + offset;

        // Setting the camera rotation to a little bit down side towards the player
        transform.rotation = Quaternion.Euler(12, 0, 0);
	}
}
