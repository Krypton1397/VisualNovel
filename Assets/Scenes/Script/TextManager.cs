using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextManager : MonoBehaviour
{
    [SerializeField] Text nameCharecter;
    [SerializeField] Text textCharecter;
    [SerializeField] GameObject LoseWindow;
    [SerializeField] Text textLoseWindow;

    public static TextManager Instance;
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
        nameCharecter.text = "Suspicious girl";
        textCharecter.text = "Hello stranger,want to go with me in forest?";
    }

    public void CheckAnswerStatus()
    {
        if (textCharecter.text == "Hello stranger,want to go with me in forest?")
        {
            if (AnswerButton.Instance.answerStatus == true)
            {
                LoseWindow.SetActive(true);
                textLoseWindow.text = "You walked with this girl in forest and she killed you";
            }
        }
    }
}
