using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DarkMusic : MonoBehaviour
{
    public AudioSource Music;
    public GameObject Doors;
    public GameObject DoorWalls;
    public GameObject HiddenWall;

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            Music.Play();
            Doors.SetActive(false);
            DoorWalls.SetActive(false);
            HiddenWall.SetActive(true);
        }
    }
}
