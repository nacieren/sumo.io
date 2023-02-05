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
    public Transform þeker;
    public float timeRemaining;
    public float puan;
    int rastgeleDüþman;
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
            rastgeleDüþman = Random.Range(1, 13);
            if (rastgeleDüþman == 1)
            {
             agent.destination = target1.position;
             x = 0;
            }
            if (rastgeleDüþman == 2)
            {
                agent.destination = target2.position;
                x = 0;
            }
            if (rastgeleDüþman == 3)
            {
                agent.destination = target3.position;
                x = 0;
            }
            if (rastgeleDüþman == 4)
            {
                agent.destination = target4.position;
                x = 0;
            }
            if (rastgeleDüþman == 5)
            {
                agent.destination = target5.position;
                x = 0;
            }
            if (rastgeleDüþman >5)
            {
                agent.destination = þeker.position;
                x = 0;
            }
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != "ölüm")
        {
            gameObject.SetActive(false);
            Debug.Log("UI öldü");
        }
    }
}
