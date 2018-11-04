using UnityEngine;

public class DestroyObject : MonoBehaviour {

    public Transform player;    // A refference to the player transform
	
	// Update is called once per frame
	void Update () {

        // Checking if the player position is 10 unit forward than current objects
        if ((player.position.z >= (this.transform.position.z + 15f)) && (player.position.z <= (this.transform.position.z + 18f)))
        {
            // Destroying the current objects
            Destroy(this.gameObject);
        }
	}
}
