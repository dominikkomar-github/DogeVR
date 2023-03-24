using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestFinished : MonoBehaviour
{
    public GameObject QuestFinishedCanvas;
    public GameObject Pathway;
    public AudioClip Bork;
    public AudioSource Source; 


    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            if (Pathway.active)
            {
                Source.PlayOneShot(Bork, 1f);
                Pathway.SetActive(false);
                QuestFinishedCanvas.SetActive(true); 
                StartCoroutine(EndCanvasTime());
            }
        
        }
    }

    IEnumerator EndCanvasTime()
    {   
        yield return new WaitForSeconds(5);
        QuestFinishedCanvas.SetActive(false);
    }
}
