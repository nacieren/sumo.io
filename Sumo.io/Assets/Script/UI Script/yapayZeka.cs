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
    public Transform �eker;
    public float timeRemaining;
    public float puan;
    int rastgeleD��man;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timeRemaining > 5f)
        {
            agent.destination = target1.position;
        }
        else timeRemaining += Time.deltaTime;
        //StartCoroutine(yakala());
    }
    public IEnumerator yakala()
    {
        for (int x = 0; x < 10; x++)
        {
            yield return new WaitForSeconds(5f);
            rastgeleD��man = Random.Range(1, 13);
            if (rastgeleD��man == 1)
            {
             agent.destination = target1.position;
             x = 0;
            }
            if (rastgeleD��man == 2)
            {
                agent.destination = target2.position;
                x = 0;
            }
            if (rastgeleD��man == 3)
            {
                agent.destination = target3.position;
                x = 0;
            }
            if (rastgeleD��man == 4)
            {
                agent.destination = target4.position;
                x = 0;
            }
            if (rastgeleD��man == 5)
            {
                agent.destination = target5.position;
                x = 0;
            }
            if (rastgeleD��man >5)
            {
                agent.destination = �eker.position;
                x = 0;
            }
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != "�l�m")
        {
            gameObject.SetActive(false);
            Debug.Log("UI �ld�");
        }
    }
}
