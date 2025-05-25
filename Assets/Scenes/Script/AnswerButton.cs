using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnswerButton : MonoBehaviour
{
    [SerializeField] Text textAnswerPositive;
    [SerializeField] Text textAnswerNegative;
    public bool answerStatus;

    public static AnswerButton Instance;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    private void Start()
    {
        textAnswerPositive.text = "Yes";
        textAnswerNegative.text = "No";
    }
    public void AnswerPositive()
    {
        answerStatus = true;
        Debug.Log("Yes");
        TextManager.Instance.CheckAnswerStatus();
    }
    public void AnswerNegative()
    {
        answerStatus = false;
    }
}
