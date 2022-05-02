using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseOver : MonoBehaviour
{

    public AudioClip menuSound;
    public AudioSource AudioSourceMenuSound;
    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Menu()
    {
        AudioSourceMenuSound.PlayOneShot(menuSound);
    }
    
}
