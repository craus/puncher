using UnityEngine;
using System.Collections;

public class Hit : Ability {

    public Transform hand;

    public float minLength = 0.01f;
    public float maxLength = 2f;
    public float hitTime = 0.2f;

    protected override void Awake() {
        base.Awake();
        hand = player.GetComponentInChildren<Hand>().transform;
    }

    void FixedUpdate() {
        var scale = hand.transform.localScale;
        scale.x += (maxLength - minLength) / hitTime * (Input.GetButton(player.hit) ? 1 : -1) * Time.fixedDeltaTime;
        scale.x = Mathf.Clamp(scale.x, minLength, maxLength);
        hand.transform.localScale = scale;
    }
}
