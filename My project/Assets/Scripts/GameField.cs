using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class GameField : MonoBehaviour
{
    public InputField GetAnswer;
    public Button StartTimer;
    public Image TimeBar;
    public Text Timer;
    public Text Results;
    public Text BestTime;
    public Text Task;
    public Text CurrentScore;
    public Text BestScore;

    public float Answer;
    public float GameTimerForTask;

    public int Scores;
    public int FirstTask;
    public int SecondTask;
    public int ThreeTask;
    public int FourTask;
    public int FiveTask;

    public bool StopTimer;

    private float _gameTimer;
    private float _bestTime;
    private int _bestScore;
    private int[] _arrayIndexTask;
    private int IndexTask;
    void Start()
    {
        TimeBar = TimeBar.gameObject.GetComponent<Image>();
        StopTimer = false;
        GetAnswer.interactable = false;
        Results.text = "√Œ“Œ¬?";
        BestTime.text = "0:00";
        Timer.text = "0:30";
        Task.text = "";
        CurrentScore.text = "0";
        BestScore.text = "0";
        Scores = 0;

        _arrayIndexTask = new int[5] { 1, 2, 3, 4, 5, };
    }
    private void TimerStart()
    {
        if (StopTimer == true)
        {
            GameTimerForTask -= Time.deltaTime;
            _gameTimer += Time.deltaTime;
            int minutes = Mathf.FloorToInt(GameTimerForTask / 60);
            int seconds = Mathf.FloorToInt(GameTimerForTask - minutes * 60f);
            string textTime = string.Format("{0:0}:{1:00}", minutes, seconds);
            Timer.text = textTime;
        }
    }
    public void ButtonStartTimer()
    {
        StopTimer = true;
        StartTimer.interactable = false;
        GetAnswer.interactable = true;
        Results.text = "œŒ≈’¿À»!";
        GetAnswer.ActivateInputField();
        CreateRandomArray();
        IndexTask = FirstTask;
        GameTimerForTask = 30;
    }
    private void CheckIndexTask()
    {
        if (IndexTask == 1)
        {
            Task.text = "(-18,2+45/0,5+(4^3 *0,3))/7";
        }
        if (IndexTask == 2)
        {
            Task.text = "3+5";
        }
        if (IndexTask == 3)
        {
            Task.text = "81/9";
        }
        if (IndexTask == 4)
        {
            Task.text = "3*3";
        }
        if (IndexTask == 5)
        {
            Task.text = "8/2";
        }
    }
    private void TimerScale()
    {
        if (GameTimerForTask > 0 )
        {
            TimeBar.fillAmount = GameTimerForTask / 30;
        }
    }
    public void CreateRandomArray()
    {
        List<int> randInts = new List<int>(_arrayIndexTask);

        for (int i = 0; i < randInts.Count; i++)
        {
            int currentValue = randInts[i];
            int randIndex = Random.Range(i, randInts.Count);
            randInts[i] = randInts[randIndex];
            randInts[randIndex] = currentValue;
            FirstTask = randInts[0];
            SecondTask = randInts[1];
            ThreeTask = randInts[2];
            FourTask = randInts[3];
            FiveTask = randInts[4];
        }
    }
    private void CheckBTimerGameAndBestTime()
    {
        if (_gameTimer <= _bestTime)
        {
            int minutes = Mathf.FloorToInt(_bestTime / 60);
            int seconds = Mathf.FloorToInt(_bestTime - minutes * 60f);
            string textBestTime = string.Format("{0:0}:{1:00}", minutes, seconds);
            BestTime.text = textBestTime;
        }
    }
    private void CheckScoreAndBestScore()
    {
        if (Scores < _bestScore)
        {
            BestScore.text = _bestScore.ToString();
        }
    }
    private void PressEnter()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            GetAnswer.ActivateInputField();

            float.TryParse(GetAnswer.text, out Answer);
            if ((Answer == 13 && IndexTask == 1) || (Answer == 8 && IndexTask == 2) || (Answer == 9 && IndexTask == 3) ||
                (Answer == 9 && IndexTask == 4) || (Answer == 4 && IndexTask == 5))
            {
                if (FirstTask == IndexTask)
                {
                    GameTimerForTask = 30;
                    GetAnswer.text = "";
                    IndexTask = SecondTask;
                    Results.text = "¬≈–ÕŒ!";
                    Scores += 10;
                    CurrentScore.text = Scores.ToString();
                    if (Scores > _bestScore)
                    {
                        _bestScore = Scores;
                    }
                    return;
                }
                if (SecondTask == IndexTask)
                {
                    GameTimerForTask = 30;
                    GetAnswer.text = "";
                    IndexTask = ThreeTask;
                    Results.text = "ÃÓÎÓ‰ˆÓÏ!";
                    Scores += 10;
                    CurrentScore.text = Scores.ToString();
                    if (Scores > _bestScore)
                    {
                        _bestScore = Scores;
                    }
                    return;
                }
                if (ThreeTask == IndexTask)
                {
                    GameTimerForTask = 30;
                    GetAnswer.text = "";
                    IndexTask = FourTask;
                    Results.text = "ﬂ ‰ÛÏ‡Î Ú˚ ÚÛÔÂÂ!";
                    Scores += 10;
                    CurrentScore.text = Scores.ToString();
                    if (Scores > _bestScore)
                    {
                        _bestScore = Scores;
                    }
                    return;
                }
                if (FourTask == IndexTask)
                {
                    GameTimerForTask = 30;
                    GetAnswer.text = "";
                    IndexTask = FiveTask;
                    Results.text = "¡À≈— !";
                    Scores += 10;
                    CurrentScore.text = Scores.ToString();
                    if (Scores > _bestScore)
                    {
                        _bestScore = Scores;
                    }
                    return;
                }
                if (FiveTask == IndexTask)
                {
                    StopTimer = false;
                    Results.text = "“€ —œ–¿¬»À—ﬂ!";
                    Scores += 10;
                    CurrentScore.text = Scores.ToString();
                    GetAnswer.interactable = false;
                    GetAnswer.text = "";
                    if (_gameTimer < _bestTime || _bestTime == 0)
                    {
                        _bestTime = _gameTimer;
                    }
                    if (Scores > _bestScore)
                    {
                        _bestScore = Scores;
                        BestScore.text = Scores.ToString();
                    }
                }
            }
            else
            {
                Results.text = "ƒ”–≈Õ‹,  –»¬Œ œŒ—◊»“¿À!";
            }
        }
    }
    private void TimerStop()
    {
        if (GameTimerForTask <= 0)
        {
            StopTimer = false;
        }
        if (GameTimerForTask < 0)
        {
            Timer.text = "0:00";
            Results.text = "¬–≈Ãﬂ ¬€ÿÀŒ!";
            BestScore.text = _bestScore.ToString();
            _bestTime = _gameTimer;
        }
        if (!StopTimer)
        {
            GetAnswer.DeactivateInputField();
        }
    }
    public void RestartGame()
    {
        StartTimer.interactable = true;
        GetAnswer.interactable = false;
        StopTimer = false;
        GameTimerForTask = 30;
        Answer = 0;
        IndexTask = 0;
        _gameTimer = 0;
        Scores = 0;
        GetAnswer.text = "";
        Results.text = "√Œ“Œ¬?";
        Timer.text = "0:30";
        Task.text = "";
        CurrentScore.text = "0";
    }
    void Update()
    {
        TimerStop();
        TimerStart();
        TimerScale();
        PressEnter();
        CheckIndexTask();
        CheckBTimerGameAndBestTime();
        CheckScoreAndBestScore();
    }
}