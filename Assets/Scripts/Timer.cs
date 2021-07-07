using System;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    private TextMeshProUGUI _text;
    private float _time;

    private void Awake()
    {
        _text = GetComponent<TextMeshProUGUI>();
    }

    private void Update()
    {
        _time += Time.deltaTime;
        UpdateText();
    }

    private void UpdateText()
    {
        int minutes = (int) (_time / 60);
        int sec = (int) (_time % 60);
        int millis = (int) (_time % 1 * 100);
        _text.text = String.Format("{0:00}:{1:00}:{2:00}", minutes, sec, millis);
    }

    public void Reset()
    {
        _time = 0;
    }
}
