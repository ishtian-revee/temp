using UnityEngine;

public class Anim1 : MonoBehaviour {

    public Transform player2;    // A refference to the player transform
    public Animation anim2;      // A refference to the animation

    // Update is called once per frame
    void Update()
    {
        // Checking the position of the player
        if ((player2.position.z >= (this.transform.position.z - 28f)) && (player2.position.z <= (this.transform.position.z - 25f)))
        {
            // Playing the animation
            anim2.Play();
        }
    }
}
