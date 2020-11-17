using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainCharacterController : MonoBehaviour
{
    public string succeedSceneName = "";
    public string failuerSceneName = "";
    public string idleAnime = "";
    public string timeupAnime = "";
    public float y = 1.0f;

    private int counter = 0;

    protected void Start()
    {
        counter = 0;
    }

    // Update is called once per frame
    protected void Update()
    {
        if (Timer.seconds >= StageInfo.seconds)
        {
            GetComponent<Animator>().Play(timeupAnime);
            Invoke(nameof(IdleGameOver), 1.0f);
        }

        // TODO : transformでジャンプさせないほうが良さそう
        if (Input.GetKeyDown(KeyCode.Return))
        {
            transform.Translate(0, y, 0);
        }

        // GetComponent<Animator>().Play(idleAnime);
    }

    protected void OnCollisionEnter2D(Collision2D collision)
    {
        //Debug.Log(SceneManager.GetActiveScene().name);
        //Debug.Log(collision.gameObject.name);

        if (collision.gameObject.name == "kinoko")
        {
            Destroy(collision.gameObject);
            ++counter;

            if (counter >= StageInfo.score)
            {
                // TODO: clearした時のObject
                Invoke(nameof(IdleClear), 1.0f);
            }
        }
    }

    private void IdleGameOver()
    {
        SceneManager.LoadScene(failuerSceneName);
    }

    private void IdleClear()
    {
        SceneManager.LoadScene(succeedSceneName);
    }
}
