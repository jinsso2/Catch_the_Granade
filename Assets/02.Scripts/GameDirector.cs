using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameDirector : MonoBehaviour
{
    List<GameObject> objList1 = new List<GameObject>();
    List<GameObject> objList2 = new List<GameObject>();
    List<GameObject> objList3 = new List<GameObject>();
    public GameObject obj;

    int createIndex;

    void Start()
    {
        createIndex = 0;

        for(int i = 0; i < 3; i++)
        {
            objList1.Add(obj);
        }
        for (int i = 0; i < 3; i++)
        {
            objList2.Add(obj);
        }
        for (int i = 0; i < 3; i++)
        {
            objList3.Add(obj);
        }
        // 게임이 시작할 때 2번째 줄에 오브젝트 추가, 추가된 오브젝트를 리스트에서 삭제
        for (int i = -3; i < 4; i += 3)
        {
            Instantiate(objList1[0], new Vector2(i, 0), Quaternion.identity);
            objList1.RemoveAt(0);
        }
    }

    void Update()
    {
        // 점수가 10점과 21점일 때 각각 createIndex를 1, 2로 변경
        if (GameManager.instance.score == 10 && createIndex == 0)
        {
            for (int i = -3; i < 4; i += 3)
            {
                Instantiate(objList2[0], new Vector2(i, -3), Quaternion.identity);
                objList2.RemoveAt(0);
            }
            createIndex = 1;
        }
        else if (GameManager.instance.score == 21 && createIndex == 1)
        {
            for (int i = -3; i < 4; i += 3)
            {
                Instantiate(objList3[0], new Vector2(i, 3), Quaternion.identity);
                objList3.RemoveAt(0);
            }
            createIndex = 2;
        }

        /*
        switch (createIndex)
        {
            // createIndex가 1이면 3번째 줄에 오브젝트 추가, 추가된 오브젝트를 리스트에서 삭제 후 createIndex를 0으로 변경
            case 1:
                for (int i = -3; i < 4; i += 3)
                {
                    Instantiate(objList2[0], new Vector2(i, -3), Quaternion.identity);
                    objList2.RemoveAt(0);
                }
                createIndex = 0;
                break;
            // createIndex가 2이면 1번째 줄에 오브젝트 추가, 추가된 오브젝트를 리스트에서 삭제 후 createIndex를 0으로 변경
            case 2:
                for (int i = -3; i < 4; i += 3)
                {
                    Instantiate(objList3[0], new Vector2(i, 3), Quaternion.identity);
                    objList3.RemoveAt(0);
                }
                createIndex = 0;
                break;
        }
        */
    }
}
