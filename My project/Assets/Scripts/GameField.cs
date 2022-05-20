using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameField : MonoBehaviour
{
    public InputField GetAnswer;
    public Image TimeBar;
    public Text Timer;
    public Text Results;
    public Text BestTime;

    public float Answer;
    public float GameTime;

    public bool StopTimer;
    public bool MemoryTimer;

    void Start()
    {
        TimeBar =TimeBar.gameObject.GetComponent<Image>();
        StopTimer = true;
        MemoryTimer = false;
        GameTime = 180;
        Results.text = "онеуюкх!";
    }
    void Update()
    {
        //Timer Stop
        if (GameTime <= 0 ^ Answer == 13)
        {
            StopTimer = false;
                    }
        //Timer
        if (StopTimer == true)
        {
            GameTime -= Time.deltaTime;

            int minutes = Mathf.FloorToInt(GameTime / 60);
            int seconds = Mathf.FloorToInt(GameTime - minutes * 60f);
            string textTime = string.Format("{0:0}:{1:00}", minutes, seconds);
            Timer.text = textTime;
            BestTime.text = PlayerPrefs.GetString("BestTime");
        }
        // Timer scale
        if (GameTime > 0)
        {
            TimeBar.fillAmount = GameTime / 180;
        }
        // Press Enter to Results and save best time
        if (Input.GetKeyDown(KeyCode.Return))
        {
            float.TryParse(GetAnswer.text, out Answer);
            if (Answer != 13)
            {
                Results.text = "дспемэ, йпхбн онявхрюк!";
            }
            else
            {
                Results.text = "бяе бепмн!";
                BestTime.text = Timer.text;
                PlayerPrefs.SetString("BestTime", BestTime.text);
            }
        }
    }
    public void RestartGame()
    {
        SceneManager.LoadScene("Game");
    }
}

