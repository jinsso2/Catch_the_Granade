using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class StartScene : MonoBehaviour
{
    AudioSource audioSource;
    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
        GameManager.instance.score = 0;
    }

    public void btnDown()
    {
        audioSource.Play();
        SceneManager.LoadScene("ExplainScene");
    }

}
