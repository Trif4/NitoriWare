﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ComicBubble_ComicData {

    [Header("Main Gameobjects")]

    [Tooltip("Strip GameObject")]
    [SerializeField]
    private GameObject strip;

    [Tooltip("Bubble GameObject")]
    [SerializeField]
    private GameObject speechBubble;

    [Tooltip("Character Target GameObject")]
    [SerializeField]
    private GameObject characterTarget;

    [Tooltip("Indicator GameObject")]
    [SerializeField]
    private GameObject indicator;

    [Header("Before Bubble Completion")]

    [Tooltip("Fix the speed in which the bubble will be completed, independently of the amount of characters in the bubble")]
    [SerializeField]
    private float speechSpeed;

    [Header("After Bubble Completion")]

    [Tooltip("Distance that the bubble travels upwards after being completed")]
    [SerializeField]
    private float distanceAfterCompletion;

    [Tooltip("Speed in which the bubble moves after being completed")]
    [SerializeField]
    private float speedAfterCompletion;

    [Tooltip("Disable strip animator after completion?")]
    [SerializeField]
    private bool disableStripAnimator;


    public GameObject getStrip() { return strip; }

    public GameObject getBubble() { return speechBubble; }

    public GameObject getTarget() { return characterTarget; }

    public GameObject getIndicator() { return indicator;  }

    public float getSpeechSpeed() { return speechSpeed; }

    public float getDistanceAfterCompletion() { return distanceAfterCompletion; }

    public float getSpeedAfterCompletion() { return speedAfterCompletion; }

    public bool stripAnimatorCanBeDisabled() { return disableStripAnimator;  }
}

public static class ComicBubble_ComicDataExtension
{

    public static GameObject getStrip(this List<ComicBubble_ComicData> dataList, int index)
    {
        return dataList[index].getStrip();
    }

    public static GameObject getBubble(this List<ComicBubble_ComicData> dataList, int index)
    {
        return dataList[index].getBubble();
    }

    public static GameObject getTarget(this List<ComicBubble_ComicData> dataList, int index)
    {
        return dataList[index].getTarget();
    }

    public static GameObject getIndicator(this List<ComicBubble_ComicData> dataList, int index)
    {
        return dataList[index].getIndicator();
    }

    public static float getSpeechSpeed(this List<ComicBubble_ComicData> dataList, int index)
    {
        return dataList[index].getSpeechSpeed();
    }

    public static float getDistanceAfterCompletion(this List<ComicBubble_ComicData> dataList, int index)
    {
        return dataList[index].getDistanceAfterCompletion();
    }


    public static float getSpeedAfterCompletion(this List<ComicBubble_ComicData> dataList, int index)
    {
        return dataList[index].getSpeedAfterCompletion();
    }

    public static bool stripAnimatorCanBeDisabled(this List<ComicBubble_ComicData> dataList, int index)
    {
        return dataList[index].stripAnimatorCanBeDisabled();
    }
}

