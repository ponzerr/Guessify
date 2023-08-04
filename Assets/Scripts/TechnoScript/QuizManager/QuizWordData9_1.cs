using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuizWordData9_1 : MonoBehaviour
{

    [SerializeField] private Text wordText;

    [HideInInspector]
    public char wordValue;
    // Start is called before the first frame update
    private Button buttonComponent;

    private void Awake()
    {
        buttonComponent = GetComponent<Button>();
        if (buttonComponent)
        {
            buttonComponent.onClick.AddListener(() => WordSelected());

        }
    }

    public void SetWord(char value)
    {
        wordText.text = value + "";
        wordValue = value;
    }

    private void WordSelected()
    {
        QuizManager9_1.instance.SelectedOption(this);
    }
  
}
