using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText; // Puanı gösterecek UI Text nesnesi
    private float score = 0f; // Toplanan puan

    void Update()
    {
        // Karakterin y pozisyonunu kullanarak puanı arttır
        score = Mathf.Max(0, transform.position.y);
        scoreText.text = " " + Mathf.Floor(score).ToString();
    }
}
