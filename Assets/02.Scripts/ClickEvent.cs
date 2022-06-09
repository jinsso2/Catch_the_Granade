using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickEvent : MonoBehaviour
{
    Vector2 m_Position;
    Vector2 pos;
    Camera Camera;
    void Start()
    {
        Camera = GameObject.Find("Main Camera").GetComponent<Camera>();
        pos = new Vector2(0, 10);
    }

   
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            m_Position = Input.mousePosition;
            m_Position = Camera.ScreenToWorldPoint(m_Position);
           
            transform.position = m_Position;
            gameObject.SetActive(true);
        }
        if (Input.GetMouseButtonUp(0))
        {
            gameObject.SetActive(false);
            gameObject.transform.position = pos;
            gameObject.SetActive(true);
        }
    }
}
