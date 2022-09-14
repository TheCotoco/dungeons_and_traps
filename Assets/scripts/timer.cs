using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class timer : MonoBehaviour
{
    private float timeDuration = 3f * 60;
    private float contador;

    [SerializeField]
    private TextMeshProUGUI firstminute;
    [SerializeField]
    private TextMeshProUGUI secondminute;
    [SerializeField]
    private TextMeshProUGUI firstsecond;
    [SerializeField]
    private TextMeshProUGUI secondsecond;
    void Start()
    {
        ResetTimer();
    }

    // Update is called once per frame
    void Update()
    {
        
        if(contador > 0)
        {
            contador -= Time.deltaTime;
            UpdateTimerDisplay(contador);
        }
        else
        {
            Timesup();
        }
             
    }

    private void ResetTimer()
    {
        contador = timeDuration; 
    }

    private void UpdateTimerDisplay(float time)
    {
        float minutes = Mathf.FloorToInt(time / 60);
        float seconds = Mathf.FloorToInt(time % 60);

        string currentTime = string.Format("{00:00}{1:00}", minutes, seconds);
        firstminute.text = currentTime[0].ToString();
        secondminute.text = currentTime[1].ToString();
        firstsecond.text = currentTime[2].ToString();
        secondsecond.text = currentTime[3].ToString();
        
    }

    private void Timesup()
    {
        SceneManager.LoadScene("game_over");
    }
}
