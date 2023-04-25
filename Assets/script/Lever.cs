using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


/*
 * void OnTriggerStay(Collider collision) 
if get key input [e]
transform.scale = vector3(-1, -1, -1);
bowser animator. play (TURN ON EMPTY WIN OBJECT)
StartCoroutine (ShowB2Dialogue())
Ienumerator ShowB2Dialogue()
Textbox.text "NOOOOOOOOO CURSE CONVENIENTLY PLACED LEVERRRRSSSS!!!!"
turn Textbox on
yield return WaitForSeconds(Texttimer);
turn Textbox off
*/

public class Lever : MonoBehaviour
{

    //BOWSER
    public Animator bowSink;
    public AudioSource soLong;

    //LEVER
    public Animator leverTurn;
    [SerializeField]
    bool playerInRange = false;
    bool bowTriggered = false;

    //TEXTBOX
    public TMP_Text bowDText;
    public GameObject textBox;

    //TRIGGERZONE
    public BoxCollider triggerZone;


    public float textTimer = 4f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && playerInRange == true && bowTriggered == false)
        {
            leverTurn.SetBool("handleTurned", true);
            bowSink.SetBool("handleTurned", true);

            StartCoroutine(ShowB2Dialogue());
            bowTriggered = true;
        }
        
    }

    /* THIS WAS NOT WORKING VERY WELL, MOST TIMES PRESSING E DID NOT WORK
    private void OnTriggerStay(Collider Lever)
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            leverTurn.SetBool("handleTurned", true);
            bowSink.SetBool("handleTurned", true);
            StartCoroutine(ShowB2Dialogue());
        }
    }
    */

    private void OnTriggerEnter(Collider other)
    {
        playerInRange = true;
    }

    private void OnTriggerExit(Collider other)
    {
        playerInRange = false;
    }

    IEnumerator ShowB2Dialogue()
    {
       bowDText.text = "NOOOOOOOOO CURSE CONVENIENTLY PLACED LEVERRRRSSSS!!!!";
       textBox.SetActive(true);
       yield return new WaitForSeconds(textTimer);

       textBox.SetActive(false);
        

    }

}
