using UnityEngine;
using UnityEngine.SceneManagement;

public class WaterScript : MonoBehaviour {

	// Use this for initialization
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Coin.coinsCount = 0;
            SceneManager.LoadScene("MainScene");
        }
    }
}
