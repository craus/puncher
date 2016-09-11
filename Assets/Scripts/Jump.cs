using UnityEngine;
using System.Collections;

public class Jump : Ability {

    public float jumpForce = 20f;

    void Update() {
    }

    void FixedUpdate() {
        player.rb.AddForce(Vector2.up * Input.GetAxis(player.vertical) * jumpForce);
    }
}
