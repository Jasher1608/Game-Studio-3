using System.Collections.Generic;
using UnityEngine;
using System.Diagnostics;

public class WaveFunctionCollapse : MonoBehaviour
{
    public Tile[] allTiles; // Assign all tile prefabs in the inspector
    public int gridWidth;
    public int gridHeight;

    private Tile[,] grid;
    private Dictionary<Tile, int> tileIndices;
    private Dictionary<int, List<int>> compatibleTilesUp;
    private Dictionary<int, List<int>> compatibleTilesDown;
    private Dictionary<int, List<int>> compatibleTilesLeft;
    private Dictionary<int, List<int>> compatibleTilesRight;
    private PriorityQueue<Vector2Int, int> priorityQueue;
    private Stack<State> backtrackingStack;

    private Stopwatch timer = new Stopwatch();

    void Start()
    {
        timer.Start();
        InitializeTileConnections();
        GenerateGrid();
    }

    void InitializeTileConnections()
    {
        tileIndices = new Dictionary<Tile, int>();
        compatibleTilesUp = new Dictionary<int, List<int>>();
        compatibleTilesDown = new Dictionary<int, List<int>>();
        compatibleTilesLeft = new Dictionary<int, List<int>>();
        compatibleTilesRight = new Dictionary<int, List<int>>();

        // Populate tileIndices
        for (int i = 0; i < allTiles.Length; i++)
        {
            var tile = allTiles[i];
            tileIndices[tile] = i;
        }

        // Initialize compatibility lists
        for (int i = 0; i < allTiles.Length; i++)
        {
            compatibleTilesUp[i] = new List<int>();
            compatibleTilesDown[i] = new List<int>();
            compatibleTilesLeft[i] = new List<int>();
            compatibleTilesRight[i] = new List<int>();
        }

        // Populate compatibility lists
        for (int i = 0; i < allTiles.Length; i++)
        {
            var tile = allTiles[i];

            foreach (var otherTile in tile.upNeighbours)
            {
                if (tileIndices.TryGetValue(otherTile, out int otherTileIndex))
                {
                    compatibleTilesUp[i].Add(otherTileIndex);
                }
            }

            foreach (var otherTile in tile.downNeighbours)
            {
                if (tileIndices.TryGetValue(otherTile, out int otherTileIndex))
                {
                    compatibleTilesDown[i].Add(otherTileIndex);
                }
            }

            foreach (var otherTile in tile.leftNeighbours)
            {
                if (tileIndices.TryGetValue(otherTile, out int otherTileIndex))
                {
                    compatibleTilesLeft[i].Add(otherTileIndex);
                }
            }

            foreach (var otherTile in tile.rightNeighbours)
            {
                if (tileIndices.TryGetValue(otherTile, out int otherTileIndex))
                {
                    compatibleTilesRight[i].Add(otherTileIndex);
                }
            }
        }
    }

    void GenerateGrid()
    {
        grid = new Tile[gridWidth, gridHeight];
        priorityQueue = new PriorityQueue<Vector2Int, int>();
        backtrackingStack = new Stack<State>();

        // Initialize all cells with all possible tiles
        for (int x = 0; x < gridWidth; x++)
        {
            for (int y = 0; y < gridHeight; y++)
            {
                grid[x, y] = null;
                priorityQueue.Enqueue(new Vector2Int(x, y), 4);
            }
        }

        while (priorityQueue.Count > 0)
        {
            var cell = priorityQueue.Dequeue();
            List<Tile> possibleTiles = GetPossibleTiles(cell);

            // If no possible tiles, backtrack
            while (possibleTiles.Count == 0)
            {
                if (backtrackingStack.Count == 0)
                {
                    UnityEngine.Debug.LogError("No possible tiles to place. Generation failed.");
                    return;
                }

                State previousState = backtrackingStack.Pop();
                RestoreState(previousState);
                cell = previousState.cell;
                possibleTiles = previousState.possibleTiles;
                possibleTiles.Remove(previousState.selectedTile);
            }

            Tile selectedTile = possibleTiles[Random.Range(0, possibleTiles.Count)];
            grid[cell.x, cell.y] = selectedTile;

            // Save state for backtracking
            backtrackingStack.Push(new State(cell, new List<Tile>(possibleTiles), selectedTile));

            // Instantiate the tile prefab
            Instantiate(selectedTile.prefab, new Vector3(cell.x, cell.y, 0), Quaternion.identity);

            // Propagate constraints to neighbors
            PropagateConstraints(cell);
        }

        // Ensure all cells are filled
        FillRemainingCells();

        timer.Stop();
        UnityEngine.Debug.Log($"Map generation took {timer.ElapsedMilliseconds}ms");
    }

    List<Tile> GetPossibleTiles(Vector2Int cell)
    {
        List<Tile> possibleTiles = new List<Tile>(allTiles);

        // Check up
        if (cell.y < gridHeight - 1 && grid[cell.x, cell.y + 1] != null)
        {
            possibleTiles = FilterTiles(possibleTiles, compatibleTilesDown[tileIndices[grid[cell.x, cell.y + 1]]]);
        }

        // Check down
        if (cell.y > 0 && grid[cell.x, cell.y - 1] != null)
        {
            possibleTiles = FilterTiles(possibleTiles, compatibleTilesUp[tileIndices[grid[cell.x, cell.y - 1]]]);
        }

        // Check left
        if (cell.x > 0 && grid[cell.x - 1, cell.y] != null)
        {
            possibleTiles = FilterTiles(possibleTiles, compatibleTilesRight[tileIndices[grid[cell.x - 1, cell.y]]]);
        }

        // Check right
        if (cell.x < gridWidth - 1 && grid[cell.x + 1, cell.y] != null)
        {
            possibleTiles = FilterTiles(possibleTiles, compatibleTilesLeft[tileIndices[grid[cell.x + 1, cell.y]]]);
        }

        return possibleTiles;
    }

    List<Tile> FilterTiles(List<Tile> possibleTiles, List<int> compatibleIndices)
    {
        List<Tile> filteredTiles = new List<Tile>();

        foreach (var tile in possibleTiles)
        {
            if (compatibleIndices.Contains(tileIndices[tile]))
            {
                filteredTiles.Add(tile);
            }
        }

        return filteredTiles;
    }

    void PropagateConstraints(Vector2Int cell)
    {
        Queue<Vector2Int> cellsToCheck = new Queue<Vector2Int>();
        cellsToCheck.Enqueue(cell);

        while (cellsToCheck.Count > 0)
        {
            Vector2Int currentCell = cellsToCheck.Dequeue();

            List<Vector2Int> neighbors = GetNeighbors(currentCell);

            foreach (var neighbor in neighbors)
            {
                if (grid[neighbor.x, neighbor.y] == null)
                {
                    List<Tile> possibleTiles = GetPossibleTiles(neighbor);

                    if (possibleTiles.Count == 0)
                    {
                        UnityEngine.Debug.LogError("No possible tiles to place. Generation failed.");
                        return;
                    }

                    if (possibleTiles.Count == 1)
                    {
                        grid[neighbor.x, neighbor.y] = possibleTiles[0];
                        Instantiate(possibleTiles[0].prefab, new Vector3(neighbor.x, neighbor.y, 0), Quaternion.identity);
                        cellsToCheck.Enqueue(neighbor);
                    }
                    else
                    {
                        priorityQueue.Enqueue(neighbor, possibleTiles.Count);
                    }
                }
            }
        }
    }

    List<Vector2Int> GetNeighbors(Vector2Int cell)
    {
        List<Vector2Int> neighbors = new List<Vector2Int>();

        if (cell.y < gridHeight - 1) neighbors.Add(new Vector2Int(cell.x, cell.y + 1));
        if (cell.y > 0) neighbors.Add(new Vector2Int(cell.x, cell.y - 1));
        if (cell.x > 0) neighbors.Add(new Vector2Int(cell.x - 1, cell.y));
        if (cell.x < gridWidth - 1) neighbors.Add(new Vector2Int(cell.x + 1, cell.y));

        return neighbors;
    }

    void RestoreState(State state)
    {
        grid[state.cell.x, state.cell.y] = null;
    }

    void FillRemainingCells()
    {
        for (int x = 0; x < gridWidth; x++)
        {
            for (int y = 0; y < gridHeight; y++)
            {
                if (grid[x, y] == null)
                {
                    List<Tile> possibleTiles = GetPossibleTiles(new Vector2Int(x, y));

                    if (possibleTiles.Count > 0)
                    {
                        Tile selectedTile = possibleTiles[Random.Range(0, possibleTiles.Count)];
                        grid[x, y] = selectedTile;
                        Instantiate(selectedTile.prefab, new Vector3(x, y, 0), Quaternion.identity);
                    }
                    else
                    {
                        UnityEngine.Debug.LogError($"Failed to place tile at ({x}, {y}). No possible tiles.");
                    }
                }
            }
        }
    }
}

public class PriorityQueue<TElement, TPriority> where TPriority : System.IComparable<TPriority>
{
    private List<KeyValuePair<TElement, TPriority>> _baseHeap;

    public PriorityQueue()
    {
        _baseHeap = new List<KeyValuePair<TElement, TPriority>>();
    }

    public int Count => _baseHeap.Count;

    public void Enqueue(TElement element, TPriority priority)
    {
        Insert(priority, element);
    }

    public TElement Dequeue()
    {
        if (!IsEmpty)
        {
            var result = RemoveMin();
            return result;
        }
        else
        {
            throw new System.InvalidOperationException("Priority queue is empty");
        }
    }

    public bool IsEmpty => _baseHeap.Count == 0;

    private void Insert(TPriority priority, TElement element)
    {
        KeyValuePair<TElement, TPriority> val = new KeyValuePair<TElement, TPriority>(element, priority);
        _baseHeap.Add(val);

        // Heapify-up
        HeapifyUp(_baseHeap.Count - 1);
    }

    private TElement RemoveMin()
    {
        if (_baseHeap.Count == 0)
        {
            throw new System.InvalidOperationException("Priority queue is empty");
        }

        KeyValuePair<TElement, TPriority> min = _baseHeap[0];
        if (_baseHeap.Count <= 1)
        {
            _baseHeap.Clear();
        }
        else
        {
            _baseHeap[0] = _baseHeap[_baseHeap.Count - 1];
            _baseHeap.RemoveAt(_baseHeap.Count - 1);

            // Heapify-down
            HeapifyDown(0);
        }

        return min.Key;
    }

    private void HeapifyUp(int pos)
    {
        if (pos >= _baseHeap.Count)
        {
            return;
        }

        var parent = (pos - 1) / 2;
        if (parent < 0 || parent >= _baseHeap.Count)
        {
            return;
        }

        if (_baseHeap[pos].Value.CompareTo(_baseHeap[parent].Value) < 0)
        {
            var temp = _baseHeap[pos];
            _baseHeap[pos] = _baseHeap[parent];
            _baseHeap[parent] = temp;

            HeapifyUp(parent);
        }
    }

    private void HeapifyDown(int pos)
    {
        if (pos >= _baseHeap.Count)
        {
            return;
        }

        var smallest = pos;
        var left = 2 * pos + 1;
        var right = 2 * pos + 2;

        if (left < _baseHeap.Count && _baseHeap[left].Value.CompareTo(_baseHeap[smallest].Value) < 0)
        {
            smallest = left;
        }

        if (right < _baseHeap.Count && _baseHeap[right].Value.CompareTo(_baseHeap[smallest].Value) < 0)
        {
            smallest = right;
        }

        if (smallest != pos)
        {
            var temp = _baseHeap[pos];
            _baseHeap[pos] = _baseHeap[smallest];
            _baseHeap[smallest] = temp;

            HeapifyDown(smallest);
        }
    }
}

public class State
{
    public Vector2Int cell;
    public List<Tile> possibleTiles;
    public Tile selectedTile;

    public State(Vector2Int cell, List<Tile> possibleTiles, Tile selectedTile)
    {
        this.cell = cell;
        this.possibleTiles = possibleTiles;
        this.selectedTile = selectedTile;
    }
}
