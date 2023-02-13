using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class ItemCollector : MonoBehaviour
{
    private int coins = 0;

    [SerializeField] private TextMeshProUGUI coinsText;

    [SerializeField] private AudioSource collectSFX;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Coin"))
        {
            Destroy(collision.gameObject);
            collectSFX.Play();
            coins++;
            coinsText.text = "Coins: " + coins;
        }

        if (collision.gameObject.CompareTag("End Object") && coins == 19)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

}
