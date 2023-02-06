using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class sağKısımUI : MonoBehaviour
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
        if (other.gameObject.name == "ön")
        {
            karakter.GetComponent<Animator>().enabled = true;
            AI2.GetComponent<NavMeshAgent>().speed = 0f;
                anim.SetBool("sağKısa", true);
                StartCoroutine(kısa());
            Debug.Log("Çarptı");
        }
        if (other.gameObject.name == "arka" || other.gameObject.name == "yanSağ" || other.gameObject.name == "yanSol")
        {
            karakter.GetComponent<Animator>().enabled = true;
            AI2.GetComponent<NavMeshAgent>().speed = 0f;
            anim.SetBool("sağKısa", true);
            StartCoroutine(kısa());
        }

    }


    public IEnumerator uzun()
    {
        yield return new WaitForSeconds(.85f);
        karakter.GetComponent<Animator>().enabled = false;
        karakter.SetActive(false);
        yeniKarakter.SetActive(true);
        AI2.GetComponent<NavMeshAgent>().speed = 0.2f;
        AI.transform.Translate(Vector3.left * 0.2052497f);
        yeniKarakter.transform.position = tp.position;
        Debug.Log("veri çekildi");
    }
    public IEnumerator kısa()
    {
        yield return new WaitForSeconds(.65f);
        karakter.GetComponent<Animator>().enabled = false;
        karakter.SetActive(false);
        yeniKarakter.SetActive(true);
        AI2.GetComponent<NavMeshAgent>().speed = 0.2f;
        AI.transform.Translate(Vector3.left * 0.1160107f);
        yeniKarakter.transform.position = tp.position;
        Debug.Log("veri çekildi");
    }

}
