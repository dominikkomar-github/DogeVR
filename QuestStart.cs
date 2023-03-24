using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestStart : MonoBehaviour
{
    public GameObject QuestCanvas;
    public GameObject Pathway;
    public AudioClip Whine;
    public AudioSource Source; 

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            Source.PlayOneShot(Whine, 1f);
            QuestCanvas.SetActive(true);
            Pathway.SetActive(true);

            StartCoroutine(StartCanvasTime());
        }
    }

    IEnumerator StartCanvasTime()
    {
        //turn off after 5 seconds 
        yield return new WaitForSeconds(5);
        QuestCanvas.SetActive(false);
    }
}
