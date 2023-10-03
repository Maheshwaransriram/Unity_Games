using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0, 7.5f, -10);
    private float smoothSpeed = 0.15f;

    // Update is called once per frame
    void LateUpdate()
    {
        // Position the camera behind the player
        transform.position = player.transform.position + offset;

        // Rotate the camera to match the player's rotation
        Quaternion desiredRotation = player.transform.rotation;
        transform.rotation = Quaternion.Lerp(transform.rotation, desiredRotation, smoothSpeed);
    }
}
