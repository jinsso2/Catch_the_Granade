using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance = null;
    AudioSource audio;

    private void Awake()
    {
        audio = GetComponent<AudioSource>();
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            if(instance != this)
            {
                Destroy(this.gameObject);
            }
        }
    }

    private void Update()
    {
        if (SceneManager.GetActiveScene().name == "ClearScene")
        {
            audio.mute = true;
        }
        else
        {
            audio.mute = false;
        }
    }
    public int score = 0;
    public int bomb = 25;
    public static bool isFail = false;
    public static bool isClear = false;
}
