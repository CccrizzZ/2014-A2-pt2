using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    public AudioSource[] MusicPlayerArray;
    void Start()
    {
        if (GameObject.FindGameObjectsWithTag("BGM").Length > 1)
        {
            Destroy(gameObject);
        }
    }
}
