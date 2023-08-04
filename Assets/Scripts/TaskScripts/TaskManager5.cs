using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class TaskManager5 : MonoBehaviour
{   

    public static TaskManager5 instance;

    [SerializeField]
    private TaskQuestionData5 question;

    [SerializeField]
    public TaskWordData5[] answerWordArray;

    [SerializeField]
    public TaskWordData5[] optionWordArray;

    private char[] charArray = new char[12];
    private int currentAnswerIndex = 0;
    private bool correctAnswer = true;
    private List<int> selectedWordIndex;
	public GameObject WinPanel;
    public GameObject LosePanel;
    public CoinSystem coins;
    public bool GameAktif = true;

    public AudioSource win;
    public AudioSource lose;
    public AudioSource erase;
    public AudioSource answer;

    private void Awake(){
        if(instance == null) instance = this;
        else
            Destroy(gameObject);
        
        selectedWordIndex = new List<int>();
    }
    
    private void Start() {
        SetQuestion();
    }

    private void SetQuestion(){

        currentAnswerIndex = 0;
        selectedWordIndex.Clear();

        ResetQuestion();
        ResetLastWord();
		

        for(int i = 0; i < question.answer.Length; i++)
        {
            charArray[i] = char.ToUpper(question.answer[i]);
        }

        for(int i = question.answer.Length; i < optionWordArray.Length; i++)
        {
            charArray[i] = (char)UnityEngine.Random.Range(65, 91);
        }

        charArray = ShuffleList.ShuffleListItems<char>(charArray.ToList()).ToArray();

        for(int i = 0; i < optionWordArray.Length; i++)
        {
            optionWordArray[i].SetWord(charArray[i]);
        }
    }  

    public void SelectedOption(TaskWordData5 wordData){

        if(currentAnswerIndex >= question.answer.Length) return;

        selectedWordIndex.Add(wordData.transform.GetSiblingIndex());
        answerWordArray[currentAnswerIndex].SetWord(wordData.wordValue);
        answer.Play();
        wordData.gameObject.SetActive(false);
        currentAnswerIndex++;

        if(currentAnswerIndex >= question.answer.Length){
            correctAnswer = true;

            for(int i = 0; i < question.answer.Length; i++){
                if(char.ToUpper(question.answer[i]) != char.ToUpper(answerWordArray[i].wordValue)){
                    correctAnswer = false;
                    break;
                }
            }

            if(correctAnswer){
                Debug.Log("Your answer is correct !");
				WinPanel.SetActive(true);
				win.Play();
                GameAktif = false;
            }else if(!correctAnswer){
                Debug.Log("Your answer is incorrect, please try again !");
                LosePanel.SetActive(true);
                lose.Play();
                GameAktif = false;
            }
        }
    }

    public void ResetQuestion(){
        for(int i = 0; i < answerWordArray.Length; i++){
            answerWordArray[i].gameObject.SetActive(true);
            answerWordArray[i].SetWord('_');
        }
        for(int i = question.answer.Length; i < answerWordArray.Length; i++){
            answerWordArray[i].gameObject.SetActive(false);
        }

        for (int i = 0; i < optionWordArray.Length; i++)
        {
            optionWordArray[i].gameObject.SetActive(true);
        }

        currentAnswerIndex = 0;
    }

    public void ResetLastWord(){
        if(selectedWordIndex.Count > 0)
        {
            int index = selectedWordIndex[selectedWordIndex.Count - 1];
            optionWordArray[index].gameObject.SetActive(true);
            selectedWordIndex.RemoveAt(selectedWordIndex.Count - 1);
            currentAnswerIndex--;
            answerWordArray[currentAnswerIndex].SetWord('_');
            erase.Play();
        }
        
    }


}

[System.Serializable]
public class TaskQuestionData5{

    public string answer;
}