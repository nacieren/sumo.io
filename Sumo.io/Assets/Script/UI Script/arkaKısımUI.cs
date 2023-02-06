using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class arkaKısımUI : MonoBehaviour
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
            AI2.GetComponent<NavMeshAgent>().speed = 0;
                anim.SetBool("arkaKısa", true);
                StartCoroutine(kısa());
            Debug.Log("Çarptı");
        }

        if (other.gameObject.name == "arka" || other.gameObject.name == "yanSağ" || other.gameObject.name == "yanSol")
        {
            karakter.GetComponent<Animator>().enabled = true;
            AI2.GetComponent<NavMeshAgent>().speed = 0;
            anim.SetBool("arkaKısa", true);
            StartCoroutine(kısa());
        }
    }

    public IEnumerator uzun()
    {
        yield return new WaitForSeconds(1.35f);
        karakter.GetComponent<Animator>().enabled = false;
        karakter.SetActive(false);
        yeniKarakter.SetActive(true);
        AI2.GetComponent<NavMeshAgent>().speed = 0.2f;
        AI.transform.Translate(Vector3.forward * 0.5351559f);
        yeniKarakter.transform.position = tp.position;
        Debug.Log("veri çekildi");
    }
    public IEnumerator kısa()
    {
        yield return new WaitForSeconds(1.05f);
        karakter.GetComponent<Animator>().enabled = false;
        karakter.SetActive(false);
        yeniKarakter.SetActive(true);
        AI2.GetComponent<NavMeshAgent>().speed = 0.2f;
        AI.transform.Translate(Vector3.forward * 0.3567706f);
        yeniKarakter.transform.position = tp.position;
        Debug.Log("veri çekildi");
    }

}
