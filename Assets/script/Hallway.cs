using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Hallway : MonoBehaviour
{
    /*
     void OnTriggerEnter(Collider collision) 
turn on Gooma game object (animation will play)
StartCoroutine (ShowGDialogue())
void OnTriggerExit(Collider collision) 
Turn this game object off
Ienumerator ShowGDialogue()
Textbox.text "I AM KANYE GOOMF HERE TO DESTROY YOU DO NOT MOVE"
turn Textbox on
yield return WaitForSeconds(Texttimer);
turn Textbox off
desirable fade textbox ?
    */

    //GOOMBA
    public GameObject kanyeGoomf;

    //TEXTBOX
    public TMP_Text kanyeGoomfText;
    public GameObject textBox;

    public float textTimer = 4f;

    //TRIGGERZONE
    public BoxCollider triggerZone;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider nextbot)
    {
        kanyeGoomf.SetActive(true);
        textBox.SetActive(true);
        StartCoroutine(ShowGDialogue());
    }

    //TRIGGER EXIT- TURN TRIGGER ZONE COMPONENT OFF SO PLAYER CANNOT REPEAT/SPAM COROUTINE
    private void OnTriggerExit(Collider nextbot)
    {
        triggerZone.enabled = false;

    }

    //DIALOGUE VISIBILITY TIMER
    IEnumerator ShowGDialogue()
    {
        kanyeGoomfText.text = "I AM KANYE GOOMF HERE TO DESTROY YOU. DO NOT MOVE";
        yield return new WaitForSeconds(textTimer);
        textBox.SetActive(false);
    }
}
