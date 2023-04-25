using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
/*
 *Bowser platform cs
void OnTriggerEnter(Collider collision) 
turn on Bowser game object
turn on Bowser fire game object (fire particles with prewarm)
StartCoroutine (ShowB1Dialogue())

Ienumerator ShowB1Dialogue()
Textbox.text "BWAHA I AM BOW. YOU BETTER NOT TOUCH THAT CONVENIENTLY PLACED LEVER...."
turn Textbox on
yield return WaitForSeconds(Texttimer);
turn Textbox off
*/
public class BowserPlatform : MonoBehaviour
{
    //BOWSER
    public GameObject bow;

    //TEXTBOX
    public TMP_Text bowText;
    public GameObject textBox;

    //TRIGGERZONE
    public BoxCollider triggerZone;


    public float textTimer = 5f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider Bowser)
    {
        bow.SetActive(true);
        textBox.SetActive(true);
        StartCoroutine(ShowBDialogue());

    }

    //TRIGGER EXIT- TURN TRIGGER ZONE COMPONENT OFF SO PLAYER CANNOT REPEAT/SPAM COROUTINE
    private void OnTriggerExit(Collider nextbot)
    {
        triggerZone.enabled = false;

    }

    //DIALOGUE VISIBILITY TIMER
    IEnumerator ShowBDialogue()
    {
        bowText.text = "BWAHA I AM RGB BOW. YOU BETTER NOT TOUCH THAT CONVENIENTLY PLACED LEVER...";
        yield return new WaitForSeconds(textTimer);
        textBox.SetActive(false);
    }
}
