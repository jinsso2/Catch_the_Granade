using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Scene2_Script : MonoBehaviour
{
   
    public void btnDown()
    {
        SceneManager.LoadScene("StartScene");
        GameManager.isFail = false;
        GameManager.isClear = false;
        GameManager.instance.bomb = 25;
        Timer.t = 0;
    }
}
