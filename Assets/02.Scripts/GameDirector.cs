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
        // ������ ������ �� 2��° �ٿ� ������Ʈ �߰�, �߰��� ������Ʈ�� ����Ʈ���� ����
        for (int i = -3; i < 4; i += 3)
        {
            Instantiate(objList1[0], new Vector2(i, 0), Quaternion.identity);
            objList1.RemoveAt(0);
        }
    }

    void Update()
    {
        // ������ 10���� 21���� �� ���� createIndex�� 1, 2�� ����
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
            // createIndex�� 1�̸� 3��° �ٿ� ������Ʈ �߰�, �߰��� ������Ʈ�� ����Ʈ���� ���� �� createIndex�� 0���� ����
            case 1:
                for (int i = -3; i < 4; i += 3)
                {
                    Instantiate(objList2[0], new Vector2(i, -3), Quaternion.identity);
                    objList2.RemoveAt(0);
                }
                createIndex = 0;
                break;
            // createIndex�� 2�̸� 1��° �ٿ� ������Ʈ �߰�, �߰��� ������Ʈ�� ����Ʈ���� ���� �� createIndex�� 0���� ����
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
