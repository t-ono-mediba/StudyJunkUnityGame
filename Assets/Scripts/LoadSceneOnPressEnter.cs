using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/**
 * Enter（Return）を押したらSceneを切り替える
 */
public class LoadSceneOnPressEnter : MonoBehaviour
{
    /**
     * @property string sceneName
     * インスペクタから
     */
    public string sceneName;

    /**
     * Update
     */
    protected void Update()
    {
        if (Input.GetKey(KeyCode.Return))
        {
            SceneManager.LoadScene(sceneName);
        }
    }
}
