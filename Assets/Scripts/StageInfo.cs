using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageInfo : MonoBehaviour
{
    public static int seconds = 60;
    public static int stage = 1;
    public static int score = 3;

    [SerializeField] private int stageSeconds;
    [SerializeField] private int stageNumber;
    [SerializeField] private int completeScore;

    protected void Awake()
    {
        seconds = stageSeconds;
        stage = stageNumber;
        score = completeScore;
    }
}
