using UnityEngine;
using System.Collections;

public class Move : Ability {

    public float moveForce = 100f;

    void FixedUpdate() {
        player.rb.AddForce(Vector2.right * Input.GetAxis(player.horizontal) * moveForce);
    }
}
