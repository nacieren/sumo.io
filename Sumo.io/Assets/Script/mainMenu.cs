using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class mainMenu : MonoBehaviour
{
    public Animator animator;
    public GameObject startButton;
    public GameObject ba�lang��;
    public float timeRemaining = 0;
    public GameObject karakter;
    public GameObject oyun��i;
    public GameObject s�reBitti;
    public TextMeshProUGUI playerScoreText;
    public TextMeshProUGUI playerScoreTextFinal;
    public TextMeshProUGUI timer;
    public TextMeshProUGUI player;
    private float time = 90;
    void Start()
    {
        startButton.SetActive(true);
        animator.SetBool("ba�lad�", false);
        ba�lang��.SetActive(false);
        Time.timeScale = 0;
        oyun��i.SetActive(false);
        s�reBitti.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //UI Ekran�,biti�ler
        if (timeRemaining > 5)
        {
            ba�lang��.SetActive(false);
            timer.text = time.ToString();
            oyun��i.SetActive(true);
        }
        else timeRemaining += Time.deltaTime;
        time -= Time.deltaTime;
        playerScoreText.text = (karakter.GetComponent<karakterKontrolMobil>().puan-50).ToString();
        player.text = (karakter.GetComponent<karakterKontrolMobil>().player.ToString()+" Player");
        if (time<0)
        {
            Time.timeScale = 0;
            playerScoreTextFinal.text= "Puan�n�z = "+(karakter.GetComponent<karakterKontrolMobil>().puan - 50).ToString();
            s�reBitti.SetActive(true);
        }
    }
    //Oyunu ba�latan fonksiyon
    public void startGame()
    {
        animator.SetBool("ba�lad�", true);
        Time.timeScale = 1;
        startButton.SetActive(false);
        ba�lang��.SetActive(true);
    }
    public void yenidenOyna()
    {
        SceneManager.LoadScene(0);
    }
}
