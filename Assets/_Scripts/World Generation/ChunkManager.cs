using UnityEngine;
using System.Collections.Generic;

public class ChunkManager : MonoBehaviour
{
    public GameObject player;
    public GameObject[] chunkPrefabs;
    public int chunkSize = 12;
    public int renderDistance = 3;

    private Vector2Int playerChunkPosition;
    private Dictionary<Vector2Int, GameObject> chunks = new Dictionary<Vector2Int, GameObject>();

    void Start()
    {
        playerChunkPosition = GetChunkPosition(player.transform.position);
        GenerateChunksAroundPlayer();
    }

    void Update()
    {
        Vector2Int newPlayerChunkPosition = GetChunkPosition(player.transform.position);

        if (newPlayerChunkPosition != playerChunkPosition)
        {
            playerChunkPosition = newPlayerChunkPosition;
            GenerateChunksAroundPlayer();
        }
    }

    Vector2Int GetChunkPosition(Vector3 position)
    {
        return new Vector2Int(
            Mathf.FloorToInt(position.x / chunkSize),
            Mathf.FloorToInt(position.y / chunkSize)
        );
    }

    void GenerateChunksAroundPlayer()
    {
        HashSet<Vector2Int> activeChunks = new HashSet<Vector2Int>();

        for (int x = -renderDistance; x <= renderDistance; x++)
        {
            for (int y = -renderDistance; y <= renderDistance; y++)
            {
                Vector2Int chunkPosition = new Vector2Int(playerChunkPosition.x + x, playerChunkPosition.y + y);
                activeChunks.Add(chunkPosition);

                if (!chunks.ContainsKey(chunkPosition))
                {
                    Vector3 chunkWorldPosition = new Vector3(chunkPosition.x * chunkSize, chunkPosition.y * chunkSize, 0);
                    GameObject newChunk = Instantiate(GetRandomChunkPrefab(), chunkWorldPosition, Quaternion.identity);
                    chunks.Add(chunkPosition, newChunk);
                }
                else
                {
                    chunks[chunkPosition].SetActive(true);
                }
            }
        }

        foreach (var chunk in chunks)
        {
            if (!activeChunks.Contains(chunk.Key))
            {
                chunk.Value.SetActive(false);
            }
        }
    }

    GameObject GetRandomChunkPrefab()
    {
        return chunkPrefabs[Random.Range(0, chunkPrefabs.Length)];
    }
}
