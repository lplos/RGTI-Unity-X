using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DustCollecting : MonoBehaviour
{
    public DustSpawner dusty;
    public GameOverScreen GameOverScreen;
    public int Dust;// = dusty.DustCount;
    public TextMeshProUGUI dustCounter;

    void Start(){
        //Debug.Log(dusty.DustCount);
        dustCounter.text = "Dust to collect: " + dusty.DustCount;
        // Ensure dusty is not null before accessing DustCount
        if (dusty != null)
        {
            Dust = dusty.DustCount;
            //Debug.Log(Dust);
        }
        else
        {
            Debug.LogError("DustSpawner reference is null in DustCollecting script.");
        }
    }
    private void OnTriggerEnter(Collider other){
        if (other.transform.tag == "Dust")
        {
            Dust--;
            FindObjectOfType<AudioManager>().Play("Suck");
            dustCounter.text = "Dust to collect: " + Dust.ToString();
            Destroy(other.gameObject);
        }
        if(Dust == 0){
            GameOverScreen.Setup();
        }

    }
}
