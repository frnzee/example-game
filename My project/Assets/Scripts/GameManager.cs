using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    public GameObject CalculatorAnchor;
    public GameObject StartMenuAnchor;
    private bool _fadeOut = false;
    private bool _fadeIn = false;
    public CanvasGroup StartMenu;
    private readonly float _rightAnswer = 5575E-2F;
    public InputField yourAnswer;
    public Text gameResult;
    public Text timerText;
    public Text bestTime;
    public float timerValue;
    public bool _timerRunning = false;
    public void Awake()
    {
        StartMenuAnchor.SetActive(true);
    }
    public void Click()
    {
        _fadeOut = true;
    }
    private void Update()
    {
        if (_fadeOut)
        {
            if (StartMenu.alpha >= 0)
            {
                StartMenu.alpha -= 2 * Time.deltaTime;
                if (StartMenu.alpha == 0)
                {
                    _fadeOut = false;
                    StartMenuAnchor.SetActive(false);
                    _timerRunning = true;
                }
            }
        }
        if (_timerRunning)
        {
            timerValue += Time.deltaTime;
            timerText.text = timerValue.ToString("F2");
        }
        if (_fadeIn)
        {
            if (StartMenu.alpha <= 1)
            {
                StartMenu.alpha += 2 * Time.deltaTime;
                if (StartMenu.alpha == 1)
                {
                    _fadeIn = false;
                }
            }
        }
    }
    public void Reset()
    {
        yourAnswer.text = "";
        _fadeIn = true;
        _timerRunning = false;
        StartMenuAnchor.SetActive(true);
        timerValue = 0;
        timerText.text = "0.00";
        yourAnswer.text = string.Empty;
    }
    public void CheckAnswer()
    {
        if (yourAnswer.text.ToString() == string.Empty)
        {
            GameObject.Find("AnswerField").GetComponent<Image>().color = new Color(255, 255, 255);
            gameResult.text = "← Enter your answer";
        }
        else if (float.Parse(yourAnswer.text) == _rightAnswer)
        {
            GameObject.Find("GameResult").GetComponent<Image>().color = new Color(0, 255, 0);
            gameResult.text = "Success!";
            _timerRunning = false;
            if (bestTime.text.ToString() == string.Empty)
            {
                bestTime.text = timerValue.ToString("F2");
            }
            else if (timerValue < float.Parse(bestTime.text))
            {
                bestTime.text = timerValue.ToString("F2");
            }
        }
        else
        {
            GameObject.Find("GameResult").GetComponent<Image>().color = new Color(255, 0, 0);
            gameResult.text = "Wrong!";
        }
    }
}