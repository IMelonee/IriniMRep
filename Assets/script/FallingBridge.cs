using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 /* Ienumerator ShowGDialogue()
Textbox.text "I AM KANYE GOOMF HERE TO DESTROY YOU DO NOT MOVE"
turn Textbox on
yield return WaitForSeconds(Texttimer);
    turn Textbox off
    desirable fade textbox ?
   */
    //bridge tile rigidbody.gravity = true;

public class FallingBridge : MonoBehaviour
{

    public Material fallingActivate;
    public MeshRenderer materialRenderer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void OnTriggerEnter(Collider collision)
    {

    
        StartCoroutine(BridgeFallDelay());
        materialRenderer.material = fallingActivate;
    }

 
    IEnumerator BridgeFallDelay()
    {
        yield return new WaitForSeconds(1.5f);
        GetComponent<Rigidbody>().useGravity = true;

    }
}
