using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class önKısım : MonoBehaviour
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
                anim.SetBool("önKısa", true);
                StartCoroutine(kısa());
            Debug.Log("Çarptı");
        }
       
    }

 
    public IEnumerator uzun()
    {
        yield return new WaitForSeconds(1.15f);
        karakter1.GetComponent<Animator>().enabled = false;
        karakter1.SetActive(false);
        yeniKarakter.SetActive(true);
        sumo.GetComponent<karakterKontrolMobil>().speed = 0.24f;
        sumo.transform.Translate(Vector3.back * 0.2554f);
        yeniKarakter.transform.position = tp.position;
        sumo.GetComponent<karakterKontrolMobil>().joysKontrol = true;


        Debug.Log("veri çekildi");
    }
    public IEnumerator kısa()
    {
        yield return new WaitForSeconds(.85f);
        karakter1.GetComponent<Animator>().enabled = false;
        karakter1.SetActive(false);
        yeniKarakter.SetActive(true);
        sumo.GetComponent<karakterKontrolMobil>().speed = 0.24f;
        sumo.transform.Translate(Vector3.back * 0.1338f);
        yeniKarakter.transform.position = tp.position;
        sumo.GetComponent<karakterKontrolMobil>().joysKontrol = true;


        Debug.Log("veri çekildi");
    }

}
