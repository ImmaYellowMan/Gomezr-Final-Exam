using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TextWriter : MonoBehaviour
{
    public Text playerName;
    public Text NewScore;
    public Text Lives;
    // Start is called before the first frame update
    void Start()
    {
        playerName.text = PlayerWriter.N.ToString();
        NewScore.text = ScoreKeeper.newScore.ToString();
        Lives.text = LivesTracker.lives.ToString();
    }
}
         
        
    



    

