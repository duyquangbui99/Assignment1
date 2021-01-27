using UnityEngine;
using UnityEngine.UI;


public class Score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;
    double pp;
    float playerPosition;

    // Update is called once per frame
    void Update()
    {
        pp = player.position.z + 43.75; // + 43.75 since player porsition at z is - 43.75, set z to 0
        playerPosition = (float)pp; //convert double to float player position
        scoreText.text = playerPosition.ToString("0");
    }
}
