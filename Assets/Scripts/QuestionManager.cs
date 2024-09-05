using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class QuestionManager : MonoBehaviour
{
    public List<Question> questions = new List<Question>();

    public TextMeshProUGUI uiText;

    void Start()
    {
        uiText.text = questions[1].questionText;
    }


}
