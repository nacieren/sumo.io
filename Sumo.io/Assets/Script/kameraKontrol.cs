using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kameraKontrol : MonoBehaviour
{
    public Transform target;
    public float timeRemaining = 0;

    void FixedUpdate()
    {
        //kamera takip
        transform.position = Vector3.Lerp(transform.position, target.transform.position, 0.3f);
        
        //Giriş animasyonunun bitirilişi
        if (timeRemaining > 5)
        {
            GetComponent<Animator>().enabled = false;
        }
        else timeRemaining += Time.deltaTime;
    }

}
