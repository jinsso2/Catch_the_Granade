using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObjectScript : MonoBehaviour
{
    private RaycastHit2D hit;
    AudioSource audioSource;
    float time;
    float rand;

    void Start()
    {
        gameObject.GetComponent<SpriteRenderer>().color = Color.white;
        audioSource = gameObject.GetComponent<AudioSource>();
        rand = Random.Range(1f, 10f);
    }
    
   
    void Update()
    {
        time += Time.deltaTime;
        setRandomColor();
        HitScan();
    }

    void setRandomColor()
    {
        if (gameObject.GetComponent<SpriteRenderer>().color == Color.white && time > rand)
        {
            rand = Random.Range(1f, 10f);
            gameObject.GetComponent<SpriteRenderer>().color = Color.red;
            time = 0;
        }
        if (gameObject.GetComponent<SpriteRenderer>().color == Color.red && time > 0.7f)
        {
            SceneManager.LoadScene("Scene_2");
            GameManager.isFail = true;
        }
    }
    private void HitScan()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            hit = Physics2D.Raycast(pos, Vector2.zero);
            if (hit.collider != null)
            {
                Debug.Log(hit.collider.gameObject.name);
                if (hit.collider.gameObject.GetComponent<SpriteRenderer>().color == Color.red)
                {
                    Debug.Log("red");
                    GameManager.instance.score++;
                    GameManager.instance.bomb--;
                    audioSource.Play();
                    hit.collider.gameObject.GetComponent<SpriteRenderer>().color = Color.white;
                }
                else
                {
                    Debug.Log("white");
                }
            }
        }
    }

}
