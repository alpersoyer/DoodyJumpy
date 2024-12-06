using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{
    public GameObject platformPrefab; // Platform prefab
    public int numberOfPlatforms = 10; // Toplam platform sayısı
    public float verticalSpacing = 1.5f; // Platformlar arasındaki sabit dikey mesafe
    public float horizontalOffset = 2f; // Platformların sağ-sol kayma mesafesi

    void Start()
    {
        Vector3 spawnPosition = new Vector3(0, 0, 0); // İlk platformun başlangıç noktası
        bool spawnOnRight = true; // İlk platform sağa mı yoksa sola mı?

        for (int i = 0; i < numberOfPlatforms; i++)
        {
            // Yükseklik arttıkça platformları sırayla sağa veya sola kaydır
            spawnPosition.y += verticalSpacing;

            if (spawnOnRight)
                spawnPosition.x = horizontalOffset; // Sağ tarafta platform oluştur
            else
                spawnPosition.x = -horizontalOffset; // Sol tarafta platform oluştur

            Instantiate(platformPrefab, spawnPosition, Quaternion.identity);

            // Bir sonraki platformu diğer tarafa koy
            spawnOnRight = !spawnOnRight;
        }
    }
}
