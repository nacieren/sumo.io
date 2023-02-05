using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class arkaKısım : MonoBehaviour
{
    public GameObject karakter1;
    public GameObject yeniKarakter;
    public GameObject sumo;
    public Transform tp;
    public Animator anim;
    public float puan;
    public void Update()
    {
        puan = sumo.GetComponent<karakterKontrolMobil>().puan;
    }


    //Çarpışma kodları
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name == "ön" )
        {
            sumo.GetComponent<karakterKontrolMobil>().joysKontrol = false;
            karakter1.GetComponent<Animator>().enabled = true;
            sumo.GetComponent<karakterKontrolMobil>().speed = 0;
            if (other.GetComponent<önKısımUI>().puan / puan > 1.25 && other.GetComponent<önKısımUI>().puan >= 1500)
            {
                anim.SetBool("arkaUzun", true);
                StartCoroutine(uzun());
            }
            else
            {
                anim.SetBool("arkaKısa", true);
                StartCoroutine(kısa());
            }
            Debug.Log("Çarptı");
        }
        if (other.gameObject.name == "arka" || other.gameObject.name == "yanSağ" || other.gameObject.name == "yanSol")
        {
            sumo.GetComponent<karakterKontrolMobil>().joysKontrol = false;
            karakter1.GetComponent<Animator>().enabled = true;
            sumo.GetComponent<karakterKontrolMobil>().speed = 0;
            anim.SetBool("arkaKısa", true);
            StartCoroutine(kısa());
        }
    }


    public IEnumerator uzun()
    {
        yield return new WaitForSeconds(1.35f);
        karakter1.GetComponent<Animator>().enabled = false;
        karakter1.SetActive(false);
        yeniKarakter.SetActive(true);
        sumo.GetComponent<karakterKontrolMobil>().speed = 0.24f;
        sumo.transform.Translate(Vector3.forward * 0.5351559f); 
        yeniKarakter.transform.position = tp.position;
        sumo.GetComponent<karakterKontrolMobil>().joysKontrol = true;


        Debug.Log("veri çekildi");
    }
    public IEnumerator kısa()
    {
        yield return new WaitForSeconds(1.05f);
        karakter1.GetComponent<Animator>().enabled = false;
        karakter1.SetActive(false);
        yeniKarakter.SetActive(true);
        sumo.GetComponent<karakterKontrolMobil>().speed = 0.24f;
        sumo.transform.Translate(Vector3.forward * 0.3567706f);
        yeniKarakter.transform.position = tp.position;
        sumo.GetComponent<karakterKontrolMobil>().joysKontrol = true;


        Debug.Log("veri çekildi");
    }

}
