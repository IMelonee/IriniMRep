using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

/*
 * void OnTriggerEnter(Collider collision) 
turn on TutorialUI game object
public void Continue()
turn off TutorialUI game object
void OnTriggerExit(Collider collision) 
Turn this game object off
*/
public class Tutorial : MonoBehaviour
{
    public GameObject tutorialUI;
    public BoxCollider triggerZone;
    public GameObject playerScript;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider Player)
    {
        tutorialUI.SetActive(true);


    }

    private void OnTriggerExit(Collider Player)
    {
        triggerZone.enabled = false;
    }

    public void Continue()
    {

        tutorialUI.SetActive(false);
        playerScript.GetComponent<PlayerMovement>().tutorialDone = true;
    }
}
