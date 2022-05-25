using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameField : MonoBehaviour
{
    public InputField GetAnswer;
    public Button StartTimer;
    public Image TimeBar;
    public Text Timer;
    public Text Results;
    public Text BestTime;
    public Text Task;

    public float Answer;
    public float GameTime;

    private float _bestTime;

    public bool StopTimer;

    void Start()
    {
        TimeBar = TimeBar.gameObject.GetComponent<Image>();
        StopTimer = false;
        GetAnswer.interactable = false;
        GameTime = 180;
        Results.text = "√Œ“Œ¬?";
        BestTime.text = "0:00";
        Timer.text = "3:00";
        Task.text = "";
    }
    public void ButtonStartTimer()
    {
        StopTimer = true;
        Results.text = "œŒ≈’¿À»!";
        Task.text = "(-18,2+45/0,5+(4^3 *0,3))/7";
        StartTimer.interactable = false;
        GetAnswer.interactable = true;
    }
    private void TimerStop()
    {
        if (GameTime <= 0 || Answer == 13)
        {
            StopTimer = false;
        }
    }
    private void TimerStart()
    {
        if (StopTimer == true)
        {
            GameTime -= Time.deltaTime;

            int minutes = Mathf.FloorToInt(GameTime / 60);
            int seconds = Mathf.FloorToInt(GameTime - minutes * 60f);
            string textTime = string.Format("{0:0}:{1:00}", minutes, seconds);
            Timer.text = textTime;
        }
    }
    private void TimerScale()

    {
        if (GameTime > 0)
        {
            TimeBar.fillAmount = GameTime / 180;
        }
    }
    private void PressEnter()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            float.TryParse(GetAnswer.text, out Answer);
            if (Answer != 13)
            {
                Results.text = "ƒ”–≈Õ‹,  –»¬Œ œŒ—◊»“¿À!";
            }
            else
            {
                Results.text = "¬—≈ ¬≈–ÕŒ!";
                if (GameTime > _bestTime)
                {
                    _bestTime = GameTime;
                    BestTime.text = Timer.text;
                }
            }
        }
    }
    private void CheckTimeAndBestTime()
    {
        if (GameTime > _bestTime)
        {
            int minutes = Mathf.FloorToInt(_bestTime / 60);
            int seconds = Mathf.FloorToInt(_bestTime - minutes * 60f);
            BestTime.text = _bestTime.ToString(string.Format("{0:0}:{1:00}", minutes, seconds));
        }
    }
    void Update()
    {
        TimerStop();
        TimerStart();
        TimerScale();
        PressEnter();
        CheckTimeAndBestTime();
    }
    public void RestartGame()
    {
        StartTimer.interactable = true;
        GetAnswer.interactable = false;
        StopTimer = false;
        GameTime = 180;
        Answer = 0;
        GetAnswer.text = "";
        Results.text = "√Œ“Œ¬?";
        Timer.text = "3:00";
        Task.text = "";
    }

}