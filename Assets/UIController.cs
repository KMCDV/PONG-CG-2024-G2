using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIController : MonoBehaviour
{
    public TextMeshProUGUI LeftPlayerScore;
    public TextMeshProUGUI RightPlayerScore;

    public void SetLeftPlayerScore(string text)
    {
        LeftPlayerScore.SetText(text);
    }

    public void SetRightPlayerScore(string text)
    {
        RightPlayerScore.SetText(text);
    }
}
