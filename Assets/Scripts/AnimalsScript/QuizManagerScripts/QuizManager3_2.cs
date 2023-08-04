using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;


public class QuizManager3_2: MonoBehaviour, IDataPersistence
{
    [SerializeField] int m_index;

    public int index => m_index;
    public static QuizManager3_2 instance;

    [SerializeField]
    private QuestionData3_2 question;

    [SerializeField]
    private Image questionImage;
    
    [SerializeField]
    private Image questionImage2;

    [SerializeField]
    public QuizWordData3_2[] answerWordArray;

    [SerializeField]
    public QuizWordData3_2[] optionWordArray;

    [SerializeField] private Image[] starsArray;
    [SerializeField] private Color lockColor, unlockColor;
    private int starcount;

    private char[] charArray = new char[12];
    private int currentAnswerIndex = 0;
    private bool correctAnswer = true;
    private List<int> selectedWordIndex;
    public GameObject WinPanel;
    public GameObject LosePanel;
    public GameManager3 gameManager;
    public CoinSystem coins;
    public Text TextTimer;
    public int Waktu = 60;
    public bool GameAktif = true;
    public GameObject TimePanel;

    public AudioSource win;
    public AudioSource lose;
    public AudioSource erase;
    public AudioSource answer;

    private void Awake()
    {
        if (instance == null) instance = this;
        else
            Destroy(gameObject);

        selectedWordIndex = new List<int>();
    }

    public void LoadData(LevelData data)
    {
        this.starcount = data.starcount;
    }

    public void SaveData(ref LevelData data)
    {
        data.starcount = this.starcount;
    }

    private void Start()
    {
        SetQuestion();

    }

    private void SetQuestion()
    {

        currentAnswerIndex = 0;
        selectedWordIndex.Clear();

        ResetQuestion();
        ResetLastWord();

        questionImage.sprite = question.questionImage;
        questionImage2.sprite = question.questionImage2;


        for (int i = 0; i < question.answer.Length; i++)
        {
            charArray[i] = char.ToUpper(question.answer[i]);
        }

        for (int i = question.answer.Length; i < optionWordArray.Length; i++)
        {
            charArray[i] = (char)UnityEngine.Random.Range(65, 91);
        }

        charArray = ShuffleList.ShuffleListItems<char>(charArray.ToList()).ToArray();

        for (int i = 0; i < optionWordArray.Length; i++)
        {
            optionWordArray[i].SetWord(charArray[i]);
        }
    }

    public void SelectedOption(QuizWordData3_2 wordData)
    {

        if (currentAnswerIndex >= question.answer.Length) return;

        selectedWordIndex.Add(wordData.transform.GetSiblingIndex());
        answerWordArray[currentAnswerIndex].SetWord(wordData.wordValue);
        answer.Play();
        wordData.gameObject.SetActive(false);
        currentAnswerIndex++;

        if (currentAnswerIndex >= question.answer.Length)
        {
            correctAnswer = true;

            for (int i = 0; i < question.answer.Length; i++)
            {
                if (char.ToUpper(question.answer[i]) != char.ToUpper(answerWordArray[i].wordValue))
                {
                    correctAnswer = false;
                    break;
                }
            }

            if (correctAnswer && Waktu >= 30)
            {
                Debug.Log("Your answer is correct !");
                StartCoroutine(OpenWinPanel());
                win.Play();
                gameManager.WinLevel();
                coins.CoinUpdate();
                GameAktif = false;
                SetStar(3);
                starcount = 3;
                DataPersistenceManager.instance.SaveGame();
            }
            else if (correctAnswer && Waktu >= 21)
            {
                Debug.Log("Your answer is correct !");
                StartCoroutine(OpenWinPanel());
                win.Play();
                gameManager.WinLevel();
                coins.CoinUpdate2();
                GameAktif = false;
                SetStar(2);
                starcount = 2;
                DataPersistenceManager.instance.SaveGame();
            }
            else if (correctAnswer && Waktu >= 1)
            {
                Debug.Log("Your answer is correct !");
                StartCoroutine(OpenWinPanel());
                win.Play();
                gameManager.WinLevel();
                coins.CoinUpdate3();
                GameAktif = false;
                SetStar(1);
                starcount = 1;
                DataPersistenceManager.instance.SaveGame();
            }
            else if (!correctAnswer)
            {
                Debug.Log("Your answer is incorrect, please try again !");
                LosePanel.SetActive(true);
                lose.Play();
                GameAktif = false;
            }

        }
    }

    public IEnumerator OpenWinPanel()
    {
        yield return new WaitForSeconds(2f);
        WinPanel.SetActive(true);
        win.Play();
    }

    private void SetStar(int starAchieved)
    {
        for (int i = 0; i < starsArray.Length; i++)             //loop through entire star array
        {
            /// <summary>
            /// if i is less than starAchieved
            /// Eg: if 2 stars are achieved we set the start at index 0 and 1 color to unlockColor, as array start from 0 element
            /// </summary>
            if (i < starAchieved)
            {

                starsArray[i].color = unlockColor;              //set its color to unlockColor
            }
            else
            {
                starsArray[i].color = lockColor;                //else set its color to lockColor
            }
        }
    }

    public void ResetQuestion()
    {
        for (int i = 0; i < answerWordArray.Length; i++)
        {
            answerWordArray[i].gameObject.SetActive(true);
            answerWordArray[i].SetWord('_');
        }
        for (int i = question.answer.Length; i < answerWordArray.Length; i++)
        {
            answerWordArray[i].gameObject.SetActive(false);
        }

        for (int i = 0; i < optionWordArray.Length; i++)
        {
            optionWordArray[i].gameObject.SetActive(true);
        }

        currentAnswerIndex = 0;
    }

    public void ResetLastWord()
    {
        if (selectedWordIndex.Count > 0)
        {
            int index = selectedWordIndex[selectedWordIndex.Count - 1];
            optionWordArray[index].gameObject.SetActive(true);
            selectedWordIndex.RemoveAt(selectedWordIndex.Count - 1);
            currentAnswerIndex--;
            answerWordArray[currentAnswerIndex].SetWord('_');
            erase.Play();
        }

    }

    void SetText()
    {
        int Menit = Mathf.FloorToInt(Waktu / 60);
        int Detik = Mathf.FloorToInt(Waktu % 60);
        TextTimer.text = Menit.ToString("00") + ":" + Detik.ToString("00");


    }

    float s;

    void Update()
    {
        if (GameAktif)
        {
            s += Time.deltaTime;
            if (s >= 1)
            {
                Waktu--;
                s = 0;
            }
        }
        if (GameAktif && Waktu <= 0)
        {
            Debug.Log("Stage Failed");
            TimePanel.SetActive(true);
            lose.Play();
            GameAktif = false;
        }
        SetText();
    }

    public void ResetTimer()
    {
        Waktu = 60;
        SetText();
        GameAktif = true;
    }

}

[System.Serializable]
public class QuestionData3_2
{

    public Sprite questionImage;
    public Sprite questionImage2;
    public string answer;
}

