using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GamePlayTxtScript : MonoBehaviour
{
    public Text myText;
    void Update()
    {
        myText.text = "해체한 수류탄 수: " + GameManager.instance.score.ToString() + "개";
    }
}
