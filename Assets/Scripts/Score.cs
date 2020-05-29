using System;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;
    public Text gemsText;
    public bool stopScore = false;
    private int gems = 0;

    // Update is called once per frame
    void Update()
    {
        if (!stopScore && Convert.ToInt32(player.position.z)!=0)
        {            
            scoreText.text = Convert.ToInt32((player.position.z / 608 * 100)).ToString() + " %";
        }
        
    }

    public void IncrementGems()
    {
        if (!stopScore)
        {
            gems++;
            gemsText.text = gems.ToString();
        }
    }
}
