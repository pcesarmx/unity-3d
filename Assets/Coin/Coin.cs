using System.Collections;
using UnityEngine;

public class Coin : MonoBehaviour {
    public static int coinsCount = 0;

	// Use this for initialization
	void Start () {
        Coin.coinsCount++;
        Debug.Log("Game started.");
	}
	
	// Update is called once per frame
	void Update () {
        //Debug.Log("Updated");
	}

    private void FixedUpdate()
    {
        //Debug.Log("Fixed Updated");
    }

    private void LateUpdate()
    {
        Debug.Log("Late Updated");
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("The => "+other.name +" has touched " + this.name);
        if ( other.CompareTag("Player") ) {
            Coin.coinsCount--;
            Destroy(gameObject);

            if ( Coin.coinsCount == 0 ) {
                Debug.Log("Juego Terminado");
                GameObject gameManager = GameObject.Find("GameManager");
                GameObject[] fireworksSystem = GameObject.FindGameObjectsWithTag("Fireworks");
                foreach(GameObject fireworks in fireworksSystem) {
                    fireworks.GetComponent<ParticleSystem>().Play();
                }

                Destroy(gameManager);
            }
        }
    }
}
