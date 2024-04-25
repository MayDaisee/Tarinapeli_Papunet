using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Testing : MonoBehaviour
{
    public TextAsset dynamicText;

    [System.Serializable]
    public class Answers
    {
        public string one;
        public string two;
        public string three;
        public string four;
        public string five;
        public string six;

    }

    [System.Serializable]
    public class AnswerList
    {
        public Answers[] answers;
    }

    public AnswerList myAnswers = new();

    void Start()
    {
        ReadTXT();
    }

    void ReadTXT()
    {
        string[] lines = dynamicText.text.Split(";");

        int tableSize = lines.Length / 6 - 1 ;
        myAnswers.answers = new Answers[tableSize];

        for(int i = 0; i < tableSize; i++)
        {
            myAnswers.answers[i] = new Answers();
            myAnswers.answers[i].one = lines[6 * (i + 1)];
            myAnswers.answers[i].two = lines[6 * (i + 1) +1 ];
            myAnswers.answers[i].three = lines[6 * (i + 1) +2 ];
            myAnswers.answers[i].four = lines[6 * (i + 1) +3 ];
            myAnswers.answers[i].five = lines[6 * (i + 1) +4 ];
            myAnswers.answers[i].six = lines[6 * (i + 1) +5 ];

        }
    }

}
