using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    float score;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI timerText;
    public TextMeshProUGUI gameOverText;
    public Button reload;
    int seconds = 30;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Timer());
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void AddScore(int s)
    {
        score = score + s;
        scoreText.text = "Score: " + score;
    }
    public void GameOver()
    {
        gameOverText.gameObject.SetActive(true);
        reload.gameObject.SetActive(true);
        StopAllCoroutines();
    }
    public void Reload()
    {

        SceneManager.LoadScene(0);
        Debug.Log("Reload level");
    }
    IEnumerator Timer()
    {
        while (true)
        {

            timerText.text = "Timer " + seconds;
            yield return new WaitForSeconds(1);
            seconds--;
        }

    }
}
