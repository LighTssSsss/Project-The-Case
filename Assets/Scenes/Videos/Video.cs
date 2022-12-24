using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Video : MonoBehaviour
{
    public Animator fadeVideo;
    public GameObject video;
    public float tiempo;
    // Start is called before the first frame update
    void Start()
    {
        video.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        tiempo += Time.deltaTime;
        if(tiempo >= 0.1f)
        {
            video.SetActive(true);

        }

        if(tiempo >= 24)
        {
            fadeVideo.Play("FadeVideo1Out");
            Invoke("cambio", 1f);
            tiempo = 0;
        }
    }

    public void Reproduce(string nombAa)
    {
        fadeVideo.Play(nombAa);
    }

    public void cambio()
    {
        SceneManager.LoadScene(2);
    }
}
