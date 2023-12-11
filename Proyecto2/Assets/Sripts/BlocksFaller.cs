using System.Collections;
using UnityEngine;

public class BlocksFaller : MonoBehaviour
{
    public Transform[] blocks; // Array to hold the transforms of your blocks
    public float fallHeight = 10f; // Height from which the blocks will fall
    public float fallSpeed = 5f; // Speed at which the blocks will fall
    private Vector3[] originalPositions; // To store the original positions

    // Start is called before the first frame update
    void Start()
    {
        // Store original positions
        originalPositions = new Vector3[blocks.Length];
        for (int i = 0; i < blocks.Length; i++)
        {
            if (blocks[i] != null) // Check if the block reference is not null
            {
                originalPositions[i] = blocks[i].position;
                // Set the blocks to start falling from fallHeight above their original position
                blocks[i].position += Vector3.up * fallHeight;
            }
        }

        // Start coroutine to drop blocks
        StartCoroutine(DropBlocks());
    }

    IEnumerator DropBlocks()
    {
        // Wait for a moment before dropping blocks
        yield return new WaitForSeconds(1f);

        // Flag to check if all blocks are in place
        bool allBlocksInPlace = false;

        // Keep moving the blocks down until they are all in place
        while (!allBlocksInPlace)
        {
            allBlocksInPlace = true;
            for (int i = 0; i < blocks.Length; i++)
            {
                if (blocks[i] != null) // Again, check if the block reference is not null
                {
                    // Move the block towards its original position
                    blocks[i].position = Vector3.MoveTowards(blocks[i].position, originalPositions[i], fallSpeed * Time.deltaTime);

                    // Check if the block has reached its original position
                    if (blocks[i].position != originalPositions[i])
                    {
                        allBlocksInPlace = false;
                    }
                }
            }

            // Wait for the next frame
            yield return null;
        }
    }
}