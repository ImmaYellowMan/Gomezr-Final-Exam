using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static float timer = 60f;
    public Text timerSeconds;
    public Text size;
    public Text speed;
    public Text playerName;
    // Start is called before the first frame update
    void Start()
    {
        timerSeconds.text = timer.ToString();
        size.text = OptionsMenu.size.ToString();
        speed.text = OptionsMenu.speed.ToString();
        playerName.text = PlayerWriter.N.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        timerSeconds.text = "Time Left: " + timer.ToString("f2");
        
        
        if (timer <= 0f)
        {
            Debug.Log("load Next SCENE");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }


}
