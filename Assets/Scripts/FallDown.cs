using UnityEngine;

public class FallDown : MonoBehaviour {

    public Transform player;    // A refference to the player transform
    public Rigidbody rb;        // A refference to the curret objects rigidbody component

    // Update is called once per frame
    void Update()
    {
        // Checking the position of the player
        if ((player.position.z >= (this.transform.position.z - 35f)) && (player.position.z <= (this.transform.position.z - 32f)))
        {
            // Disabling current object's rigidbody component
            rb.constraints = RigidbodyConstraints.None; // It makes the object fall from above
        }
    }
}
