using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Collision : MonoBehaviour
{
    public Text countText;
    public Text winText;
    public int totalCount;

    private Rigidbody rb;
    private int count;

    private void Start() {
        rb = GetComponent<Rigidbody>();
        count = 0;
        SetCountText();
        winText.text = "";
    }

    void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Pickup")) {
            other.gameObject.SetActive(false);
            count++;
            SetCountText();
        }
    }

    void SetCountText() {
        countText.text = "Coin Count: " + count.ToString();
        if (count == totalCount) {
            winText.text = "You Win!";
        }
    }
}
