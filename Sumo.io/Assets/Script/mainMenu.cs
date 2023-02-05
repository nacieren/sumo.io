using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{
    public Animator animator;
    public GameObject startButton;
    public GameObject ba�lang��;
    public float timeRemaining = 0;
    void Start()
    {
        startButton.SetActive(true);
        animator.SetBool("ba�lad�", false);
        ba�lang��.SetActive(false);
        Time.timeScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (timeRemaining > 5)
        {
            ba�lang��.SetActive(false);
        }
        else timeRemaining += Time.deltaTime;
    
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
