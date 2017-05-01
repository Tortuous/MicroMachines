using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetOnGround : MonoBehaviour {
    public Transform resetPoint;
    public Transform player;
    public RaycastHit hit;

    private bool onFloor;

    private IEnumerator SetCheckPoint() {
        while (true) {
            
            if (Physics.Raycast(player.position, Vector3.down, out hit)) {
                if (hit.collider.tag == "Track") {
                    resetPoint.position = hit.point;
                }
                if (hit.collider.tag == "Floor" && player.position.y < 5) {
                    player.position = resetPoint.position;
                }
            }
            yield return new WaitForSeconds(0.5f);
        }
    }
   private IEnumerator Start() {
        yield return StartCoroutine("SetCheckPoint");
    }
}
