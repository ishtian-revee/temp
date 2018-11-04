using UnityEngine;
using UnityEngine.UI;

public class LevelPercent : MonoBehaviour
{
    public Transform player;    // A referrence to the player transform    
    public Text level_Percentage;
    public int x;   // Total duration of the level
    public float y;
    public string z;
    public Rigidbody rigidBody;     // A referrence to the player rigidbody

    // Update is called once per frame
    void Update()
    {
        if (player.position.z > -1)
        {
            y = (int)(((float)player.position.z / x) * 100);
            
            if (y <= 100 && rigidBody.position.y > -1f)
            {   
                z = y + "%";
                level_Percentage.text = z.ToString();
            }
        }
    }
}
