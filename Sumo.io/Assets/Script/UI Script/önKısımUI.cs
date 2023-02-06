using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class önKısımUI : MonoBehaviour
{
    public GameObject karakter;
    public GameObject yeniKarakter;
    public GameObject AI;
    public Transform tp;
    public Animator anim;
    public NavMeshAgent AI2;
    public float puan;
    public void Update()
    {
        puan = AI.GetComponent<yapayZeka>().puan;
    }


    //Çarpışma kodları
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name == "ön" )
        {
            karakter.GetComponent<Animator>().enabled = true;
            AI2.GetComponent<NavMeshAgent>().speed = 0;
                anim.SetBool("önKısa", true);
                StartCoroutine(kısa());
            Debug.Log("Çarptı");
        }
        

    }
        public IEnumerator uzun()
        {
            yield return new WaitForSeconds(1.15f);
            karakter.GetComponent<Animator>().enabled = false;
            karakter.SetActive(false);
            yeniKarakter.SetActive(true);
            AI2.GetComponent<NavMeshAgent>().speed = 0.2f;
            AI.transform.Translate(Vector3.back * 0.2554f);
            yeniKarakter.transform.position = tp.position;


            Debug.Log("veri çekildi");
        }

        public IEnumerator kısa()
        {
            yield return new WaitForSeconds(.85f);
            karakter.GetComponent<Animator>().enabled = false;
            karakter.SetActive(false);
            yeniKarakter.SetActive(true);
            AI2.GetComponent<NavMeshAgent>().speed = 0.2f;
            AI.transform.Translate(Vector3.back * 0.1338f);
            yeniKarakter.transform.position = tp.position;


            Debug.Log("veri çekildi");
        }
     private void OnCollisionEnter(Collision collision)
     {
        if (collision.gameObject.tag == "ölüm") 
     {
           gameObject.SetActive(false);
           Debug.Log("UI öldü");
           }
       }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "şeker")
        {
            AI.GetComponent<yapayZeka>().puan += 100;
            Destroy(other.gameObject);
            transform.localScale *= 1.05f;
        }
    }
}

