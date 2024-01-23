using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject fallingObjectPrefab;

    private int currentObjectCount = 0;

    void Start()
    {
        // 一定時間ごとにオブジェクトを生成
        InvokeRepeating("SpawnObject", 1f, 2f);
    }

    void SpawnObject()
    {
       
            // オブジェクトを生成
            float randomX = Random.Range(-8f * 1.7778f, 8f * 1.7778f);
            Vector3 spawnPosition = new Vector3(randomX, 6f, 0f);
            GameObject newObject = Instantiate(fallingObjectPrefab, spawnPosition, Quaternion.identity);
            Rigidbody2D rb = newObject.AddComponent<Rigidbody2D>();
            // 重力を有効にする
            rb.gravityScale = 1f;

            currentObjectCount++;
      
    }
}