using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class yapayZeka : MonoBehaviour
{
    NavMeshAgent agent;
    public Transform target1;
    public Transform target2;
    public Transform target3;
    public Transform target4;
    public Transform target5;
    public Transform target6;
    public Transform target7;
    public Transform target8;
    public Transform target9;
    public Transform target10;
    public Transform target11;
    public Transform target12;
    public Transform target13;
    public Transform target14;
    public Transform target15;
    public Transform �eker;
    public float timeRemaining;
    public float puan;
    int rastgeleD��man;
    private bool AIyakala=true;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        
    }

    // Update is called once per frame
    void Update()
    {
        //3saniyede bir kendini yenileyip �eker klonlayan kod
        if (timeRemaining > 2.3f)
        {
            if (AIyakala == true)
            {
                AIyakala = false;
                StartCoroutine(yakala());
            }
        }
        else timeRemaining += Time.deltaTime;
        
    }
    //Hi� durmamalar� i�in
    public IEnumerator yakala()
    {
        for (int x = 0; x < 1; x++)
        {
            yield return new WaitForSeconds(3f);
            rastgeleD��man = Random.Range(1, 23);
            if (rastgeleD��man == 1)
            {
             agent.destination = target1.position;
                AIyakala = true;
            }
            if (rastgeleD��man == 2)
            {
                agent.destination = target2.position;
                AIyakala = true;
            }
            if (rastgeleD��man == 3)
            {
                agent.destination = target3.position;
                AIyakala = true;
            }
            if (rastgeleD��man == 4)
            {
                agent.destination = target4.position;
                AIyakala = true;
            }
            if (rastgeleD��man == 5)
            {
                agent.destination = target5.position;
                AIyakala = true;
            }
            if (rastgeleD��man == 6)
            {
                agent.destination = target6.position;
                AIyakala = true;
            }
            if (rastgeleD��man == 7)
            {
                agent.destination = target7.position;
                AIyakala = true;
            }
            if (rastgeleD��man == 8)
            {
                agent.destination = target8.position;
                AIyakala = true;
            }
            if (rastgeleD��man == 9)
            {
                agent.destination = target9.position;
                AIyakala = true;
            }
            if (rastgeleD��man == 10)
            {
                agent.destination = target10.position;
                AIyakala = true;
            }
            if (rastgeleD��man == 11)
            {
                agent.destination = target11.position;
                AIyakala = true;
            }
            if (rastgeleD��man == 12)
            {
                agent.destination = target12.position;
                AIyakala = true;
            }
            if (rastgeleD��man == 13)
            {
                agent.destination = target13.position;
                AIyakala = true;
            }
            if (rastgeleD��man == 14)
            {
                agent.destination = target14.position;
                AIyakala = true;
            }
            if (rastgeleD��man == 15)
            {
                agent.destination = target15.position;
                AIyakala = true;
            }
            if (rastgeleD��man > 15)
            {
                agent.destination = �eker.position;
                AIyakala = true;
            }

        }
    }
   
}
