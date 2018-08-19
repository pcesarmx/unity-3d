using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour {
    public float maxTime = 60f; // Default value. If this changes on the Inspector do no expect to change on your objects. 

    private float currentTime = 0;
	// Use this for initialization
	void Start () {
        currentTime = maxTime;
	}
	
	// Update is called once per frame
	void Update () {

        currentTime -= Time.deltaTime;
        //Debug.Log("Current Time " + currentTime);
        if (currentTime <= 0) {
            Debug.Log("Has perdido :(");

            Coin.coinsCount = 0;
            SceneManager.LoadScene("MainScene");
        }
	}
}
