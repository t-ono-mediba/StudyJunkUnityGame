using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneAtSec : MonoBehaviour
{
    /**
     * @property string sceneName
     * インスペクタから
     */
    public string sceneName;

    /**
     * 
     */
    public float time = 3.0f;


    private float limitTime;

    /**
     * 
     */
    protected void Start()
    {
        limitTime = 0;
    }

    /**
     * Update
     */
    protected void Update()
    {
        limitTime += Time.deltaTime;

        if (limitTime >= time)
        {
            SceneManager.LoadScene(sceneName);
        }
    }
}
