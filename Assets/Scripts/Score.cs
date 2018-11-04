using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;    // A referrence to the player transform
    public Text scoreText;      // A referrence to the text field of the UI
    public Rigidbody rigidBody;
    public int score;
   
    // Update is called once per frame
    void Update()
    {
        if (rigidBody.position.y > .72 && player.position.z > -1)
        {
            scoreText.text = player.position.z.ToString("0");
            score = (int)player.position.z;
        }
    }
}
