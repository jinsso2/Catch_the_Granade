using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GamePlayTxtScript : MonoBehaviour
{
    public Text myText;
    void Update()
    {
        myText.text = "��ü�� ����ź ��: " + GameManager.instance.score.ToString() + "��";
    }
}
