using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GamePlayTxtScript : MonoBehaviour
{
    public Text myText;
    void Update()
    {
        myText.text = "���� ����ź �� : " + GameManager.instance.bomb.ToString() + "��";
    }
}
