using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

[RequireComponent(typeof(Camera))]
public class DynamicView : MonoBehaviour {

    float sizeMultiplier = 0.625f;

    public List<GameObject> viewObjects;

    new Camera camera;

    void Awake() {
        camera = GetComponent<Camera>();
    }

	void Update () {
        Vector3 averagePosition = viewObjects.Aggregate(Vector3.zero, (total, go) => total += go.transform.position) / viewObjects.Count;
        Vector3 minPosition = viewObjects.Aggregate(Vector3.zero, (total, go) => total = Vector3.Min(total, go.transform.position));
        Vector3 maxPosition = viewObjects.Aggregate(Vector3.zero, (total, go) => total = Vector3.Max(total, go.transform.position));

        //Debug.LogFormat("Average position: {0}", averagePosition);
        transform.position = averagePosition.Change(z: transform.position.z);

        camera.orthographicSize = (maxPosition - minPosition).magnitude * sizeMultiplier;
	}
}
