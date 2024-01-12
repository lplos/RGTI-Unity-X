using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DustCollecting : MonoBehaviour
{
    private int Dust = 0;
    public TextMeshProUGUI dustCounter;
    private void OnTriggerEnter(Collider other){
        if (other.transform.tag == "Dust")
        {
            Dust++;
            dustCounter.text = "Dust collected: " + Dust.ToString();
            Destroy(other.gameObject);
        }

    }
}
