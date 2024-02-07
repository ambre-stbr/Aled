using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool _isPlaying = true;

    private float _time;

    public TMP_Text _timer;

    public TMP_Text _life;

    public TMP_Text _points;

    public int _timeToWin;

    [SerializeField]
    private int _lifePoint;

    // Start is called before the first frame update
    void Start()
    {
        _time = Time.time; 
    }

    // Update is called once per frame
    void Update()
    {
        if (_isPlaying == true)
        {
            float currentTime = Time.time - _time;

            int minute = Mathf.FloorToInt(currentTime / 60F);
            int second = Mathf.FloorToInt(currentTime - minute * 60);
            _timer.text = string.Format("{0:0}:{1:00}", minute, second);

        }

        if (Time.time - _time >= _timeToWin)
        {
            GameOver();
        }

        if (_isPlaying == false)
        {
            GameOver();
        }

        if (_lifePoint == 0)
        {
            _isPlaying = false;
        }
    }

    void GameOver()
    {
        if ( _time == _timeToWin ) 
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
            _lifePoint -= 1;
            Destroy(other.gameObject);
        }
    }
}
