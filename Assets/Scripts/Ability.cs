using UnityEngine;
using System.Collections;

public abstract class Ability : MonoBehaviour {

    protected Player player;

    protected virtual void Awake() {
        player = GetComponentInParent<Player>();
    }
}
