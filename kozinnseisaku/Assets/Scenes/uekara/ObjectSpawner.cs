using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject fallingObjectPrefab;

    private int currentObjectCount = 0;

    void Start()
    {
        // ��莞�Ԃ��ƂɃI�u�W�F�N�g�𐶐�
        InvokeRepeating("SpawnObject", 1f, 2f);
    }

    void SpawnObject()
    {
       
            // �I�u�W�F�N�g�𐶐�
            float randomX = Random.Range(-8f * 1.7778f, 8f * 1.7778f);
            Vector3 spawnPosition = new Vector3(randomX, 6f, 0f);
            GameObject newObject = Instantiate(fallingObjectPrefab, spawnPosition, Quaternion.identity);
            Rigidbody2D rb = newObject.AddComponent<Rigidbody2D>();
            // �d�͂�L���ɂ���
            rb.gravityScale = 1f;

            currentObjectCount++;
      
    }
}