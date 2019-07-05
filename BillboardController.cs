using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BillboardController : MonoBehaviour {

	//Moves a game object when interacted with.
    public void MoveBillboard()
    {
        // calculating a position that is 1 unity unit up
        Vector3 newPosition = transform.position;
        newPosition.y += 1;

        // moving the billboard to that new position
        transform.position = newPosition;
    }
}
