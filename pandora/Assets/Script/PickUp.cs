using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public GameObject PickUpText;
    public GameObject SwordOnPlayer;
    public bool sword = false;
    public int weaponStr =1;

    // Start is called before the first frame update
    void Start()
    {
        SwordOnPlayer.SetActive(false);
        PickUpText.SetActive(false);
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {

            PickUpText.SetActive(true);

            if (Input.GetKey(KeyCode.E))
            {
                this.gameObject.SetActive(false);
                SwordOnPlayer.SetActive(true);
                PickUpText.SetActive(false);
                sword = true;
                weaponStr =5;
            }
        }
    }
    
    private void OnTriggerExit(Collider other)
    {

        PickUpText.SetActive(false);
    }
}
