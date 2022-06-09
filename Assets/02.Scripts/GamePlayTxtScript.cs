using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GamePlayTxtScript : MonoBehaviour
{
    public Text myText;
    void Update()
    {
        myText.text = "남은 수류탄 수 : " + GameManager.instance.bomb.ToString() + "개";
    }
}
