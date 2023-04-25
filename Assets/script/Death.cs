using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*
 * void OnTriggerEnter(Collider collision) 
restart scene
*/
public class Death : MonoBehaviour
{
    //SINGLETON
    public static Death current;

    public AudioSource deathSound;

    public AudioSource lavaSound;

    // Start is called before the first frame update
    void Start()
    {
        //SINGLETON CHECK
        if (current == null)
        {
            current = this;
        }
       

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //FALLING OFF OF THE MAP DEATH
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<PlayerMovement>() != null)
        {

            SceneManager.LoadScene("MainLevel");

        }
    }

    //DEATH FUNCTION TO BE USED BY OTHER SCRIPTS
    public void DeathFunction()
    {
       StartCoroutine(deathCoRoutine());    

    }

    public void LavaDeathFunction()
    {
        StartCoroutine(LavaDeathCoRoutine());

    }


    IEnumerator deathCoRoutine()
    {
        deathSound.Play();
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene("MainLevel");

    }

    IEnumerator LavaDeathCoRoutine()
    {
        lavaSound.Play();
        yield return new WaitForSeconds(2.5f);
        SceneManager.LoadScene("MainLevel");

    }
}
