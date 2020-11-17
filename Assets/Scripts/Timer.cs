using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
	public Text timerText;

	public static int seconds;

	private float countTime;

    // Update is called once per frame
    void Update()
	{
		countTime += Time.deltaTime;
		seconds = (int)countTime;

		if (seconds <= StageInfo.seconds)
        {
			timerText.text = (StageInfo.seconds - seconds).ToString();
		}
	}
}
