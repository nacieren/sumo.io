using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{
    public Animator animator;
    public GameObject startButton;
    public GameObject baþlangýç;
    public float timeRemaining = 0;
    void Start()
    {
        startButton.SetActive(true);
        animator.SetBool("baþladý", false);
        baþlangýç.SetActive(false);
        Time.timeScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (timeRemaining > 5)
        {
            baþlangýç.SetActive(false);
        }
        else timeRemaining += Time.deltaTime;
    
}
    //Oyunu baþlatan fonksiyon
    public void startGame()
    {
        animator.SetBool("baþladý", true);
        Time.timeScale = 1;
        startButton.SetActive(false);
        baþlangýç.SetActive(true);
    }
    public void yenidenOyna()
    {
        SceneManager.LoadScene(0);
    }
}
