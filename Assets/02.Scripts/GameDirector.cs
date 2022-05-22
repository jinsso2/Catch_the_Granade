using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameDirector : MonoBehaviour
{
    List<GameObject> objList = new List<GameObject>();
    public GameObject obj;

    float time;
    int createIndex;
    int waitTime;

    void Start()
    {
        waitTime = 10;
        createIndex = 0;

        for(int i = 0; i < 9; i++)
        {
            objList.Add(obj);
        }

        for (int i = -3; i < 4; i += 3)
        {
            Instantiate(objList[0], new Vector2(i, 0), Quaternion.identity);
            objList.RemoveAt(0);
        }
    }

    void Update()
    {
        time += Time.deltaTime;
        
        if (time > waitTime)
        {
            switch (createIndex)
            {
                case 0:
                    for (int i = -3; i < 4; i += 3)
                    {
                        Instantiate(objList[0], new Vector2(i, -3), Quaternion.identity);
                        objList.RemoveAt(0);
                    }
                    createIndex++;
                    time = 0;
                    break;
                case 1:
                    for (int i = -3; i < 4; i += 3)
                    {
                        Instantiate(objList[0], new Vector2(i, 3), Quaternion.identity);
                        objList.RemoveAt(0);
                    }
                    createIndex++;
                    break;
            }
            
        }
    }
}
