using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/**
 * 文字をチカチカさせる
 */
public class FlashText : MonoBehaviour
{
    /**
     * @property GameObject targetTextObj
     * Inspectorで設定
     */
    public GameObject targetTextObj;

    /**
     * @property float speed
     * 点滅スピード
     */
    public float speed = 1.0f;

    /**
     * @property Text text
     */
    private Text text;

    /**
     * @property float time
     * 点滅タイム
     */
    private float time;

    /**
     * Start
     */
    protected void Start()
    {
        text = targetTextObj.GetComponent<Text>();
    }

    /**
     * Update
     */
    protected void Update()
    {
        text.color = GetAlphaColor(text.color);
    }

    /**
     * GetAlphaColor
     */
    private Color GetAlphaColor(Color color)
    {
        time += Time.deltaTime * 5.0f * speed;
        color.a = Mathf.Sin(time) * 0.5f + 0.5f;

        return color;
    }
}
