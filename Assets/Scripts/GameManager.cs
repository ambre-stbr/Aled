using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool _isPlaying = true;

    private float Start_time;

    private float Actual_life_points;

    [SerializeField]
    private TMP_Text Timer_text;

    public TMP_Text Life_points;

    public TMP_Text Total_score;

    public int Time_win;

    [SerializeField]
    private int Total_life_points;

    // Start is called before the first frame update
    void Start()
    {
        Start_time = Time.time;
        Actual_life_points = Total_life_points;
        Life_points.text = Actual_life_points.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (_isPlaying == true)
        {
            float Current_time = Time.time - Start_time;

            int minute = Mathf.FloorToInt(Current_time / 60F);
            int second = Mathf.FloorToInt(Current_time - minute * 60);
            Timer_text.text = string.Format("{0:0}:{1:00}", minute, second);

        }

        if (Time.time - Start_time >= Time_win)
        {
            GameOver();
        }

        if (_isPlaying == false)
        {
            GameOver();
        }

        if (Total_life_points == 0)
        {
            _isPlaying = false;
        }
    }

    void GameOver()
    {
        if ( Start_time == Time_win ) 
        {

        }

        if (_isPlaying ==false)
        {

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            Actual_life_points -= 1;
            Destroy(other.gameObject);
            Life_points.text = Actual_life_points.ToString();
        }
    }
}
