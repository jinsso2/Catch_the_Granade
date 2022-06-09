using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public Text timer;
    public static float t = 0;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(!GameManager.isFail&&!GameManager.isClear) t += Time.deltaTime;

        if(SceneManager.GetActiveScene().name == "Scene_1")
        {
            timer.GetComponent<Text>().text = ((int)t).ToString();
        }
        else if (SceneManager.GetActiveScene().name == "Scene_2" || SceneManager.GetActiveScene().name == "ClearScene")
        {
            timer.GetComponent<Text>().text = ((int)t).ToString()+"√ ";
        }
    }
}
